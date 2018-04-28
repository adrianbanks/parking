using Parking.Domain;

namespace Parking.Akka.Ask.CarParkToOutput
{
    internal sealed class CarParkToOutputMessage
    {
        public CarPark CarPark { get; }

        public CarParkToOutputMessage(CarPark carPark)
        {
            CarPark = carPark;
        }
    }
}
