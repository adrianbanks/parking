using System.Threading.Tasks;
using Enexure.MicroBus;
using Parking.Domain;
using Parking.MicroBus.Send.CarParkToOutput;

namespace Parking.MicroBus.Send.BestMatchCarPark
{
    internal sealed class BestMatchCarParkCommandHandler(IMicroBus bus) : ICommandHandler<BestMatchCarParkCommand>
    {
        public async Task Handle(BestMatchCarParkCommand command)
        {
            var bestCarPark = BestMatchCalculator.CalculateBestMatch(command.CarParks);
            await bus.SendAsync(new CarParkToOutputCommand(bestCarPark));
        }
    }
}
