using Akka.Actor;
using Parking.Akka.Tell.Information;

namespace Parking.Akka.Tell;

public static class Program
{
    public static void Main()
    {
        var actorSystem = ActorSystem.Create("parking");
        var actorRef = actorSystem.ActorOf<InformationActor>();

        actorRef.Tell(new InformationMessage());

        actorSystem.WhenTerminated.Wait();
    }
}
