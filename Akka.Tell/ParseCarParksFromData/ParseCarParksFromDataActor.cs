using Akka.Actor;
using Parking.Akka.Tell.BestMatchCarPark;
using Parking.Domain;

namespace Parking.Akka.Tell.ParseCarParksFromData
{
    internal sealed class ParseCarParksFromDataActor : ReceiveActor
    {
        public ParseCarParksFromDataActor()
        {
            var bestMatchActor = Context.ActorOf<BestMatchCarParkActor>();

            Receive<ParseCarParksFromDataMessage>(message =>
            {
                var carParks = CarParkParser.Parse(message.Data);
                bestMatchActor.Tell(new BestMatchCarParkMessage(carParks));
            });
        }
    }
}
