using System.Threading.Tasks;
using Enexure.MicroBus;
using Enexure.MicroBus.MicrosoftDependencyInjection;
using Microsoft.Extensions.DependencyInjection;
using Parking.MicroBus.Send.BestMatchCarPark;
using Parking.MicroBus.Send.CarParkToOutput;
using Parking.MicroBus.Send.FetchDataFromUrl;
using Parking.MicroBus.Send.Information;
using Parking.MicroBus.Send.ParseCarParksFromData;
using Parking.MicroBus.Send.SendOutput;

namespace Parking.MicroBus.Send;

public static class Program
{
    public static async Task Main()
    {
        var busBuilder = new BusBuilder()
            .RegisterCommandHandler<InformationCommand, InformationCommandHandler>()
            .RegisterCommandHandler<FetchDataFromUrlCommand, FetchDataFromUrlCommandHandler>()
            .RegisterCommandHandler<ParseCarParksFromDataCommand, ParseCarParksFromDataCommandHandler>()
            .RegisterCommandHandler<BestMatchCarParkCommand, BestMatchCarParkCommandHandler>()
            .RegisterCommandHandler<CarParkToOutputCommand, CarParkToOutputCommandHandler>()
            .RegisterCommandHandler<SendOutputCommand, SendOutputCommandHandler>();

        var services = new ServiceCollection();
        services.RegisterMicroBus(busBuilder);
        var provider = services.BuildServiceProvider();
        var microBus = provider.GetRequiredService<IMicroBus>();

        await microBus.SendAsync(new InformationCommand());
    }
}
