using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Enexure.MicroBus;
using Enexure.MicroBus.MicrosoftDependencyInjection;
using Microsoft.Extensions.DependencyInjection;
using Parking.Domain;
using Parking.MicroBus.Query.BestMatchCarPark;
using Parking.MicroBus.Query.CarParkToOutput;
using Parking.MicroBus.Query.FetchDataFromUrl;
using Parking.MicroBus.Query.Information;
using Parking.MicroBus.Query.ParseCarParksFromData;

namespace Parking.MicroBus.Query;

public static class Program
{
    public static async Task Main()
    {
        var busBuilder = new BusBuilder()
            .RegisterQueryHandler<InformationQuery, string, InformationQueryHandler>()
            .RegisterQueryHandler<FetchDataFromUrlQuery, string, FetchDataFromUrlQueryHandler>()
            .RegisterQueryHandler<ParseCarParksFromDataQuery, IEnumerable<CarPark>, ParseCarParksFromDataQueryHandler>()
            .RegisterQueryHandler<BestMatchCarParkQuery, CarPark, BestMatchCarParkQueryHandler>()
            .RegisterQueryHandler<CarParkToOutputQuery, string, CarParkToOutputQueryHandler>();

        var services = new ServiceCollection();
        services.RegisterMicroBus(busBuilder);
        var provider = services.BuildServiceProvider();
        var microBus = provider.GetRequiredService<IMicroBus>();

        var output = await microBus.QueryAsync(new InformationQuery());
        Console.WriteLine(output);
    }
}
