using System.Collections.Generic;
using Mediator.Switch;
using Parking.Domain;

namespace Parking.SwitchMediator.ValuePublish.BestMatchCarPark;

internal sealed class BestMatchCarParkEvent(IEnumerable<CarPark> carParks) : INotification
{
    public IEnumerable<CarPark> CarParks { get; } = carParks;
}
