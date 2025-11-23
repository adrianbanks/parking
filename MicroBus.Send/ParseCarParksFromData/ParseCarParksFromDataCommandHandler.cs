using System.Threading.Tasks;
using Enexure.MicroBus;
using Parking.Domain;
using Parking.MicroBus.Send.BestMatchCarPark;

namespace Parking.MicroBus.Send.ParseCarParksFromData
{
    internal sealed class ParseCarParksFromDataCommandHandler : ICommandHandler<ParseCarParksFromDataCommand>
    {
        private readonly IMicroBus bus;

        public ParseCarParksFromDataCommandHandler(IMicroBus bus) => this.bus = bus;

        public async Task Handle(ParseCarParksFromDataCommand command)
        {
            var carParks = CarParkParser.Parse(command.Html);
            await bus.SendAsync(new BestMatchCarParkCommand(carParks));
        }
    }
}
