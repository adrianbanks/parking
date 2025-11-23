using System;
using System.Threading.Tasks;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Paramore.Brighter;
using Paramore.Brighter.Extensions.DependencyInjection;
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
        var host = new HostBuilder()
            .ConfigureServices((_, collection) =>
            {
                collection.AddBrighter().AutoFromAssemblies();
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
