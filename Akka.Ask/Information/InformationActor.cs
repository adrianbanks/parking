using System.Collections.Generic;
using Akka.Actor;
using Parking.Akka.Ask.BestMatchCarPark;
using Parking.Akka.Ask.CarParkToOutput;
using Parking.Akka.Ask.FetchDataFromUrl;
using Parking.Akka.Ask.ParseCarParksFromData;
using Parking.Domain;

namespace Parking.Akka.Ask.Information
{
    internal sealed class InformationActor : ReceiveActor
    {
        public InformationActor()
        {
            var fetchDataActor = Context.ActorOf<FetchDataFromUrlActor>();
            var parseDataActor = Context.ActorOf<ParseCarParksFromDataActor>();
            var bestMatchActor = Context.ActorOf<BestMatchCarParkActor>();
            var outputActor = Context.ActorOf<CarParkToOutputActor>();

            ReceiveAsync<InformationMessage>(async _ =>
            {
                var data = await fetchDataActor.Ask<string>(new FetchDataFromUrlMessage(SourceData.Url));
                var carParkData = await parseDataActor.Ask<IEnumerable<CarPark>>(new ParseCarParksFromDataMessage(data));
                var bestCarPark = await bestMatchActor.Ask<CarPark>(new BestMatchCarParkMessage(carParkData));
                var output = await outputActor.Ask<string>(new CarParkToOutputMessage(bestCarPark));

                Sender.Tell(output);
            });
        }
    }
}
