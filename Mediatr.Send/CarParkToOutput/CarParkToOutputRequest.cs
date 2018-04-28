using MediatR;
using Parking.Domain;

namespace Parking.Mediatr.Send.CarParkToOutput
{
    internal sealed class CarParkToOutputRequest : IRequest<string>
    {
        public CarPark CarPark { get; }

        public CarParkToOutputRequest(CarPark carPark)
        {
            CarPark = carPark;
        }
    }
}
