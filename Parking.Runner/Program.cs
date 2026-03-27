using System;
using System.Threading.Tasks;
using Parking.Domain;

namespace Parking.Runner;

internal static class Program
{
    public static async Task Main()
    {
        DataFetcher.UseFakeData = true;

        Console.WriteLine("No Framework");
        await NoFramework.Program.Main();

        Console.WriteLine();
        Console.WriteLine("Akka.NET: Ask");
        Akka.Ask.Program.Main();

        Console.WriteLine();
        Console.WriteLine("Akka.NET: Tell");
        Akka.Tell.Program.Main();

        Console.WriteLine();
        Console.WriteLine("Brighter: Brighter");
        await Brighter.Brighter.Program.Main();

        Console.WriteLine();
        Console.WriteLine("Brighter: Darker");
        await Brighter.Darker.Program.Main();

        Console.WriteLine();
        Console.WriteLine("LiteBus: Query");
        await LiteBus.Query.Program.Main();

        Console.WriteLine();
        Console.WriteLine("LiteBus: Send");
        await LiteBus.Send.Program.Main();

        Console.WriteLine();
        Console.WriteLine("LiteBus: Publish");
        await LiteBus.Publish.Program.Main();

        Console.WriteLine();
        Console.WriteLine("Mediator: Publish");
        await Mediator.Publish.Program.Main();

        Console.WriteLine();
        Console.WriteLine("Mediator: Send");
        await Mediator.Send.Program.Main();

        Console.WriteLine();
        Console.WriteLine("Mediatr: Publish");
        await Mediatr.Publish.Program.Main();

        Console.WriteLine();
        Console.WriteLine("Mediatr: Send");
        await Mediatr.Send.Program.Main();

        Console.WriteLine();
        Console.WriteLine("MicroBus: Query");
        await MicroBus.Query.Program.Main();

        Console.WriteLine();
        Console.WriteLine("MicroBus: Send");
        await MicroBus.Send.Program.Main();

        Console.WriteLine();
        Console.WriteLine("Shiny: Publish");
        await Shiny.Publish.Program.Main();

        Console.WriteLine();
        Console.WriteLine("Shiny: Request");
        await Shiny.Request.Program.Main();

        Console.WriteLine();
        Console.WriteLine("Shiny: Send");
        await Shiny.Send.Program.Main();

        Console.WriteLine();
        Console.WriteLine("SwitchMediator: Publish");
        await SwitchMediator.Publish.Program.Main();

        Console.WriteLine();
        Console.WriteLine("SwitchMediator: Send");
        await SwitchMediator.Send.Program.Main();

        Console.WriteLine();
        Console.WriteLine("SwitchMediator: ValuePublish");
        await SwitchMediator.ValuePublish.Program.Main();

        Console.WriteLine();
        Console.WriteLine("SwitchMediator: ValueSend");
        await SwitchMediator.ValueSend.Program.Main();
    }
}
