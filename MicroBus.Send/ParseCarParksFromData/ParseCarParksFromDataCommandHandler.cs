using System.Threading.Tasks;
using Enexure.MicroBus;
using Parking.Domain;
using Parking.MicroBus.Send.BestMatchCarPark;

namespace Parking.MicroBus.Send.ParseCarParksFromData
{
    internal sealed class ParseCarParksFromDataCommandHandler(IMicroBus bus) : ICommandHandler<ParseCarParksFromDataCommand>
    {
        public async Task Handle(ParseCarParksFromDataCommand command)
        {
            var carParks = CarParkParser.Parse(command.Html);
            await bus.SendAsync(new BestMatchCarParkCommand(carParks));
        }
    }
}
