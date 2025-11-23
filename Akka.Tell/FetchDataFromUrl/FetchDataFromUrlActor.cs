using Akka.Actor;
using Parking.Akka.Tell.ParseCarParksFromData;
using Parking.Domain;

namespace Parking.Akka.Tell.FetchDataFromUrl;

internal sealed class FetchDataFromUrlActor : ReceiveActor
{
    public FetchDataFromUrlActor()
    {
        var parseDataActor = Context.ActorOf<ParseCarParksFromDataActor>();

        ReceiveAsync<FetchDataFromUrlMessage>(async message =>
        {
            var data = await DataFetcher.FetchData(message.Url);
            parseDataActor.Tell(new ParseCarParksFromDataMessage(data));
        });
    }
}
