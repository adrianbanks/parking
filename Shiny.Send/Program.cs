using System.Threading.Tasks;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Parking.Shiny.Send.BestMatchCarPark;
using Parking.Shiny.Send.CarParkToOutput;
using Parking.Shiny.Send.FetchDataFromUrl;
using Parking.Shiny.Send.Information;
using Parking.Shiny.Send.ParseCarParksFromData;
using Parking.Shiny.Send.SendOutput;
using Shiny.Mediator;

namespace Parking.Shiny.Send;

public static class Program
{
    public static async Task Main()
    {
        var host = new HostBuilder()
            .ConfigureServices((_, collection) =>
            {
                collection.AddShinyMediator();

                collection.AddSingletonAsImplementedInterfaces<InformationCommandHandler>();
                collection.AddSingletonAsImplementedInterfaces<FetchDataFromUrlCommandHandler>();
                collection.AddSingletonAsImplementedInterfaces<ParseCarParksFromDataCommandHandler>();
                collection.AddSingletonAsImplementedInterfaces<BestMatchCarParkCommandHandler>();
                collection.AddSingletonAsImplementedInterfaces<CarParkToOutputCommandHandler>();
                collection.AddSingletonAsImplementedInterfaces<SendOutputCommandHandler>();
            })
            .Build();

        var mediator = host.Services.GetRequiredService<IMediator>();
        await mediator.Send(new InformationCommand());
    }
}
