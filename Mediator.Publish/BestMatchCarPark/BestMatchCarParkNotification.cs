using System.Collections.Generic;
using Mediator;
using Parking.Domain;

namespace Parking.Mediator.Publish.BestMatchCarPark;

internal sealed class BestMatchCarParkNotification(IEnumerable<CarPark> carParks) : INotification
{
    public IEnumerable<CarPark> CarParks { get; } = carParks;
}
