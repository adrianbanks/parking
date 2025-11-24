using Parking.Domain;
using Shiny.Mediator;

namespace Parking.Shiny.Request.CarParkToOutput;

internal sealed class CarParkToOutputRequest(CarPark carPark) : IRequest<string>
{
    public CarPark CarPark { get; } = carPark;
}
