using System.Threading.Tasks;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Parking.Shiny.Publish.BestMatchCarPark;
using Parking.Shiny.Publish.CarParkToOutput;
using Parking.Shiny.Publish.FetchDataFromUrl;
using Parking.Shiny.Publish.Information;
using Parking.Shiny.Publish.ParseCarParksFromData;
using Parking.Shiny.Publish.SendOutput;
using Shiny.Mediator;

namespace Parking.Shiny.Publish;

public static class Program
{
    public static async Task Main()
    {
        var host = new HostBuilder()
            .ConfigureServices((_, collection) =>
            {
                collection.AddShinyMediator();

                collection.AddSingletonAsImplementedInterfaces<InformationEventHandler>();
                collection.AddSingletonAsImplementedInterfaces<FetchDataFromUrlEventHandler>();
                collection.AddSingletonAsImplementedInterfaces<ParseCarParksFromDataEventHandler>();
                collection.AddSingletonAsImplementedInterfaces<BestMatchCarParkEventHandler>();
                collection.AddSingletonAsImplementedInterfaces<CarParkToOutputEventHandler>();
                collection.AddSingletonAsImplementedInterfaces<SendOutputEventHandler>();
            })
            .Build();

        var mediator = host.Services.GetRequiredService<IMediator>();
        await mediator.Publish(new InformationEvent());
    }
}
