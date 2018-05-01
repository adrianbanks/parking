using Akka.Actor;
using Parking.Akka.Tell.FetchDataFromUrl;
using Parking.Domain;

namespace Parking.Akka.Tell.Information
{
    internal sealed class InformationActor : ReceiveActor
    {
        public InformationActor()
        {
            var fetchDataActor = Context.ActorOf<FetchDataFromUrlActor>();

            Receive<InformationMessage>(_ =>
            {
                fetchDataActor.Tell(new FetchDataFromUrlMessage(SourceData.Url));
            });
        }
    }
}
