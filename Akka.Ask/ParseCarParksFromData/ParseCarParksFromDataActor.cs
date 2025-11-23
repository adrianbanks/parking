using Akka.Actor;
using Parking.Domain;

namespace Parking.Akka.Ask.ParseCarParksFromData
{
    internal sealed class ParseCarParksFromDataActor : ReceiveActor
    {
        public ParseCarParksFromDataActor()
        {
            Receive<ParseCarParksFromDataMessage>(message =>
            {
                var carParks = CarParkParser.Parse(message.Html);
                Sender.Tell(carParks);
            });
        }
    }
}
