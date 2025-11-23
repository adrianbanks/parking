using Akka.Actor;
using Parking.Akka.Tell.BestMatchCarPark;
using Parking.Domain;

namespace Parking.Akka.Tell.ParseDataFromHtml
{
    internal sealed class ParseDataFromHtmlActor : ReceiveActor
    {
        public ParseDataFromHtmlActor()
        {
            var bestMatchActor = Context.ActorOf<BestMatchCarParkActor>();

            Receive<ParseDataFromHtmlMessage>(message =>
            {
                var carParks = CarParkParser.Parse(message.Html);
                bestMatchActor.Tell(new BestMatchCarParkMessage(carParks));
            });
        }
    }
}
