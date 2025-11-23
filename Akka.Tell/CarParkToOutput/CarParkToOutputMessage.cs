using Parking.Domain;

namespace Parking.Akka.Tell.CarParkToOutput
{
    internal sealed class CarParkToOutputMessage(CarPark carPark)
    {
        public CarPark CarPark { get; } = carPark;
    }
}
