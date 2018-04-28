using Akka.Actor;
using Parking.Domain;

namespace Parking.Akka.Ask.ParseDataFromHtml
{
    internal sealed class ParseDataFromHtmlActor : ReceiveActor
    {
        public ParseDataFromHtmlActor()
        {
            Receive<ParseDataFromHtmlMessage>(message =>
            {
                var carParks = CarParkParser.ParseFromHtml(message.Html);
                Sender.Tell(carParks);
            });
        }
    }
}
