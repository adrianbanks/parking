using Parking.Domain;

namespace Parking.Akka.Ask.CarParkToOutput
{
    internal sealed class CarParkToOutputMessage(CarPark carPark)
    {
        public CarPark CarPark { get; } = carPark;
    }
}
