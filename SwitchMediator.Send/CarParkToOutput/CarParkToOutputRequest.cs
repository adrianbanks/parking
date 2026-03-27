using Mediator.Switch;
using Parking.Domain;

namespace Parking.SwitchMediator.Send.CarParkToOutput;

[RequestHandler(typeof(CarParkToOutputRequestHandler))]
internal sealed class CarParkToOutputRequest(CarPark carPark) : IRequest<string>
{
    public CarPark CarPark { get; } = carPark;
}
