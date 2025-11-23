using System;
using System.Threading.Tasks;
using Paramore.Brighter;
using Parking.Brighter.BestMatchCarPark;
using Parking.Brighter.CarParkToOutput;
using Parking.Brighter.FetchDataFromUrl;
using Parking.Brighter.Information;
using Parking.Brighter.ParseCarParksFromData;

namespace Parking.Brighter;

internal static class Program
{
    internal static async Task Main()
    {
        var registry = new SubscriberRegistry();
        var handlerConfiguration = new HandlerConfiguration(registry, new SimpleHandlerFactory());
        var builder = CommandProcessorBuilder.With()
            .Handlers(handlerConfiguration)
            .DefaultPolicy()
            .NoTaskQueues()
            .RequestContextFactory(new InMemoryRequestContextFactory());

        registry.RegisterAsync<InformationCommand, InformationCommandHandler>();
        registry.RegisterAsync<FetchDataFromUrlCommand, FetchDataFromUrlRequestHandler>();
        registry.RegisterAsync<ParseCarParksFromDataCommand, ParseCarParksFromDataCommandHandler>();
        registry.RegisterAsync<BestMatchCarParkCommand, BestMatchCarParkCommandHandler>();
        registry.RegisterAsync<CarParkToOutputCommand, CarParkToOutputCommandHandler>();

        var commandProcessor = builder.Build();

        await Run(commandProcessor);
    }

    private static async Task Run(CommandProcessor commandProcessor)
    {
        var informationCommand = new InformationCommand();
        await commandProcessor.SendAsync(informationCommand);

        var fetchDataFromUrlCommand = new FetchDataFromUrlCommand(informationCommand.Url);
        await commandProcessor.SendAsync(fetchDataFromUrlCommand);

        var parseCarParksFromDataCommand = new ParseCarParksFromDataCommand(fetchDataFromUrlCommand.Data);
        await commandProcessor.SendAsync(parseCarParksFromDataCommand);

        var bestMatchCarParkCommand = new BestMatchCarParkCommand(parseCarParksFromDataCommand.CarParks);
        await commandProcessor.SendAsync(bestMatchCarParkCommand);

        var carParkToOutputCommand = new CarParkToOutputCommand(bestMatchCarParkCommand.BestMatch);
        await commandProcessor.SendAsync(carParkToOutputCommand);

        Console.WriteLine(carParkToOutputCommand.Output);
    }
}