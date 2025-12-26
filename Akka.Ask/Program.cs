using System;
using Akka.Actor;
using Parking.Akka.Ask.Information;

namespace Parking.Akka.Ask;

public static class Program
{
    public static void Main()
    {
        var actorSystem = ActorSystem.Create("parking");
        var actorRef = actorSystem.ActorOf<InformationActor>();

        var task = actorRef.Ask<string>(new InformationMessage());
        Console.WriteLine(task.Result);

        actorSystem.Terminate();
        actorSystem.WhenTerminated.Wait();
    }
}
