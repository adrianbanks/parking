using Enexure.MicroBus;
using Parking.Domain;

namespace Parking.MicroBus.Send.CarParkToOutput
{
    internal sealed class CarParkToOutputCommand(CarPark bestMatch) : ICommand
    {
        public CarPark BestMatch { get; } = bestMatch;
    }
}
