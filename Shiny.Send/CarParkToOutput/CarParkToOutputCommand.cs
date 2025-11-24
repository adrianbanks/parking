using Parking.Domain;
using Shiny.Mediator;

namespace Parking.Shiny.Send.CarParkToOutput;

internal sealed class CarParkToOutputCommand(CarPark carPark) : ICommand
{
    public CarPark CarPark { get; } = carPark;
}
