using System;
using System.Threading.Tasks;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Paramore.Brighter;
using Paramore.Brighter.Extensions.DependencyInjection;
using Parking.Brighter.Brighter.BestMatchCarPark;
using Parking.Brighter.Brighter.CarParkToOutput;
using Parking.Brighter.Brighter.FetchDataFromUrl;
using Parking.Brighter.Brighter.Information;
using Parking.Brighter.Brighter.ParseCarParksFromData;

namespace Parking.Brighter.Brighter;

public static class Program
{
    public static async Task Main()
    {
        var host = new HostBuilder()
            .ConfigureServices((_, collection) =>
            {
                collection.AddBrighter().AsyncHandlers(registry =>
                {
                    registry.RegisterAsync<InformationCommand, InformationCommandHandler>();
                    registry.RegisterAsync<FetchDataFromUrlCommand, FetchDataFromUrlCommandHandler>();
                    registry.RegisterAsync<ParseCarParksFromDataCommand, ParseCarParksFromDataCommandHandler>();
                    registry.RegisterAsync<BestMatchCarParkCommand, BestMatchCarParkCommandHandler>();
                    registry.RegisterAsync<CarParkToOutputCommand, CarParkToOutputCommandHandler>();
                });
            })
            .Build();

        var commandProcessor = host.Services.GetService<IAmACommandProcessor>();

        await Run(commandProcessor);
    }

    private static async Task Run(IAmACommandProcessor commandProcessor)
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
