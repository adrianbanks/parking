using Parking.Domain;
using Shiny.Mediator;

namespace Parking.Shiny.Publish.CarParkToOutput;

internal sealed class CarParkToOutputEvent(CarPark carPark) : IEvent
{
    public CarPark CarPark { get; } = carPark;
}
