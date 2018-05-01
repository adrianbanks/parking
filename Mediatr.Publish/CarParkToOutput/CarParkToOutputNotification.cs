using MediatR;
using Parking.Domain;

namespace Parking.Mediatr.Publish.CarParkToOutput
{
    internal sealed class CarParkToOutputNotification : INotification
    {
        public CarPark CarPark { get; }

        public CarParkToOutputNotification(CarPark carPark)
        {
            CarPark = carPark;
        }
    }
}
