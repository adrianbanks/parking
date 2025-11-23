using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Paramore.Darker;
using Paramore.Darker.AspNetCore;
using Parking.Brighter.Darker.BestMatchCarPark;
using Parking.Brighter.Darker.CarParkToOutput;
using Parking.Brighter.Darker.FetchDataFromUrl;
using Parking.Brighter.Darker.Information;
using Parking.Brighter.Darker.ParseCarParksFromData;
using Parking.Domain;

namespace Parking.Brighter.Darker;

internal static class Program
{
    internal static async Task Main()
    {
        var host = new HostBuilder()
            .ConfigureServices((_, collection) =>
            {
                collection.AddDarker().AddHandlers(registry =>
                {
                    registry.Register<InformationQuery, string, InformationQueryHandler>();
                    registry.Register<FetchDataFromUrlQuery, string, FetchDataFromUrlQueryHandler>();
                    registry.Register<ParseCarParksFromDataQuery, IEnumerable<CarPark>, ParseCarParksFromDataQueryHandler>();
                    registry.Register<BestMatchCarParkQuery, CarPark, BestMatchCarParkQueryHandler>();
                    registry.Register<CarParkToOutputQuery, string, CarParkToOutputQueryHandler>();
                });
            })
            .Build();

        var queryProcessor = host.Services.GetService<IQueryProcessor>();

        await Run(queryProcessor);
    }

    private static async Task Run(IQueryProcessor queryProcessor)
    {
        var informationQuery = new InformationQuery();
        var url = await queryProcessor.ExecuteAsync(informationQuery);

        var fetchDataFromUrlQuery = new FetchDataFromUrlQuery(url);
        var data = await queryProcessor.ExecuteAsync(fetchDataFromUrlQuery);

        var parseCarParksFromDataQuery = new ParseCarParksFromDataQuery(data);
        var carParks = await queryProcessor.ExecuteAsync(parseCarParksFromDataQuery);

        var bestMatchCarParkQuery = new BestMatchCarParkQuery(carParks);
        var bestMatch = await queryProcessor.ExecuteAsync(bestMatchCarParkQuery);

        var carParkToOutputQuery = new CarParkToOutputQuery(bestMatch);
        var output = await queryProcessor.ExecuteAsync(carParkToOutputQuery);

        Console.WriteLine(output);
    }
}
