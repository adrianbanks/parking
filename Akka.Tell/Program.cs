using Akka.Actor;
using Parking.Akka.Tell.Information;

namespace Parking.Akka.Tell;

internal static class Program
{
    internal static void Main()
    {
        var actorSystem = ActorSystem.Create("parking");
        var actorRef = actorSystem.ActorOf<InformationActor>();

        actorRef.Tell(new InformationMessage());

        actorSystem.WhenTerminated.Wait();
    }
}