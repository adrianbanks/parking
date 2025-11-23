using System.Threading.Tasks;
using Autofac;
using Enexure.MicroBus;
using Enexure.MicroBus.Autofac;
using Parking.MicroBus.Send.BestMatchCarPark;
using Parking.MicroBus.Send.CarParkToOutput;
using Parking.MicroBus.Send.FetchDataFromUrl;
using Parking.MicroBus.Send.Information;
using Parking.MicroBus.Send.ParseCarParksFromData;
using Parking.MicroBus.Send.SendOutput;

namespace Parking.MicroBus.Send;

internal static class Program
{
    internal static async Task Main()
    {
        var busBuilder = new BusBuilder()
            .RegisterCommandHandler<InformationCommand, InformationCommandHandler>()
            .RegisterCommandHandler<FetchDataFromUrlCommand, FetchDataFromUrlCommandHandler>()
            .RegisterCommandHandler<ParseCarParksFromDataCommand, ParseCarParksFromDataCommandHandler>()
            .RegisterCommandHandler<BestMatchCarParkCommand, BestMatchCarParkCommandHandler>()
            .RegisterCommandHandler<CarParkToOutputCommand, CarParkToOutputCommandHandler>()
            .RegisterCommandHandler<SendOutputCommand, SendOutputCommandHandler>();

        var container = new ContainerBuilder().RegisterMicroBus(busBuilder).Build();
        var microBus = container.Resolve<IMicroBus>();

        await microBus.SendAsync(new InformationCommand());
    }
}