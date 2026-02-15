using System.Collections.Generic;
using LiteBus.Events.Abstractions;
using Parking.Domain;

namespace Parking.LiteBus.Publish.BestMatchCarPark;

internal sealed class BestMatchCarParkEvent(IEnumerable<CarPark> carParks) : IEvent
{
    public IEnumerable<CarPark> CarParks { get; } = carParks;
}
