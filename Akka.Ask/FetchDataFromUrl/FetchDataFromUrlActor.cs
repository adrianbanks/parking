using Akka.Actor;
using Parking.Domain;

namespace Parking.Akka.Ask.FetchDataFromUrl
{
    internal sealed class FetchDataFromUrlActor : ReceiveActor
    {
        public FetchDataFromUrlActor()
        {
            ReceiveAsync<FetchDataFromUrlMessage>(async message =>
            {
                await DataFetcher.FetchData(message.Url)
                    .PipeTo(Sender, Self, response => response);
            });
        }
    }
}
