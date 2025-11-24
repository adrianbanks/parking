using System;
using System.Threading.Tasks;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Parking.Shiny.Request.BestMatchCarPark;
using Parking.Shiny.Request.CarParkToOutput;
using Parking.Shiny.Request.FetchDataFromUrl;
using Parking.Shiny.Request.Information;
using Parking.Shiny.Request.ParseCarParksFromData;
using Shiny.Mediator;

namespace Parking.Shiny.Request;

internal static class Program
{
    internal static async Task Main()
    {
        var host = new HostBuilder()
            .ConfigureServices((_, collection) =>
            {
                collection.AddShinyMediator();

                collection.AddSingletonAsImplementedInterfaces<InformationRequestHandler>();
                collection.AddSingletonAsImplementedInterfaces<FetchDataFromUrlRequestHandler>();
                collection.AddSingletonAsImplementedInterfaces<ParseCarParksFromDataRequestHandler>();
                collection.AddSingletonAsImplementedInterfaces<BestMatchCarParkRequestHandler>();
                collection.AddSingletonAsImplementedInterfaces<CarParkToOutputRequestHandler>();
            })
            .Build();

        var mediator = host.Services.GetRequiredService<IMediator>();
        var output = await mediator.Request(new InformationRequest());
        Console.WriteLine(output.Result);
    }
}
