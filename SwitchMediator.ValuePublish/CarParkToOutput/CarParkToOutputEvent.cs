using Mediator.Switch;
using Parking.Domain;

namespace Parking.SwitchMediator.ValuePublish.CarParkToOutput;

internal sealed class CarParkToOutputEvent(CarPark carPark) : INotification
{
    public CarPark CarPark { get; } = carPark;
}
