using Enexure.MicroBus;
using Parking.Domain;

namespace Parking.MicroBus.Send.CarParkToOutput
{
    internal sealed class CarParkToOutputCommand : ICommand
    {
        public CarPark BestMatch { get; }

        public CarParkToOutputCommand(CarPark bestMatch)
        {
            BestMatch = bestMatch;
        }
    }
}
