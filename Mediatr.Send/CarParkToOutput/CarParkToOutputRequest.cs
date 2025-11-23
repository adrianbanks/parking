using MediatR;
using Parking.Domain;

namespace Parking.Mediatr.Send.CarParkToOutput
{
    internal sealed class CarParkToOutputRequest(CarPark carPark) : IRequest<string>
    {
        public CarPark CarPark { get; } = carPark;
    }
}
