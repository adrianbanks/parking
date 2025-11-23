using System.Threading.Tasks;
using Enexure.MicroBus;
using Parking.Domain;
using Parking.MicroBus.Send.SendOutput;

namespace Parking.MicroBus.Send.CarParkToOutput
{
    internal sealed class CarParkToOutputCommandHandler(IMicroBus bus) : ICommandHandler<CarParkToOutputCommand>
    {
        public async Task Handle(CarParkToOutputCommand command)
        {
            var output = CarParkOutputFormatter.Format(command.BestMatch);
            await bus.SendAsync(new SendOutputCommand(output));
        }
    }
}
