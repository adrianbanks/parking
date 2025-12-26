using Mediator;
using Parking.Domain;

namespace Parking.Mediator.Send.CarParkToOutput;

internal sealed class CarParkToOutputRequest(CarPark carPark) : IRequest<string>
{
    public CarPark CarPark { get; } = carPark;
}
