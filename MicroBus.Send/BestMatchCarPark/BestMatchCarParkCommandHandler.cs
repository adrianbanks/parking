using System.Threading.Tasks;
using Enexure.MicroBus;
using Parking.Domain;
using Parking.MicroBus.Send.CarParkToOutput;

namespace Parking.MicroBus.Send.BestMatchCarPark
{
    internal sealed class BestMatchCarParkCommandHandler : ICommandHandler<BestMatchCarParkCommand>
    {
        private readonly IMicroBus bus;

        public BestMatchCarParkCommandHandler(IMicroBus bus) => this.bus = bus;

        public async Task Handle(BestMatchCarParkCommand command)
        {
            var bestCarPark = BestMatchCalculator.CalculateBestMatch(command.CarParks);
            await bus.SendAsync(new CarParkToOutputCommand(bestCarPark));
        }
    }
}
