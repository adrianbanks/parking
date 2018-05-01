using Akka.Actor;
using Parking.Akka.Tell.ParseDataFromHtml;
using Parking.Domain;

namespace Parking.Akka.Tell.FetchDataFromUrl
{
    internal sealed class FetchDataFromUrlActor : ReceiveActor
    {
        public FetchDataFromUrlActor()
        {
            var parseDataActor = Context.ActorOf<ParseDataFromHtmlActor>();

            Receive<FetchDataFromUrlMessage>(async message =>
            {
                var html = await DataFetcher.FetchData(message.Url);
                parseDataActor.Tell(new ParseDataFromHtmlMessage(html));
            });
        }
    }
}
