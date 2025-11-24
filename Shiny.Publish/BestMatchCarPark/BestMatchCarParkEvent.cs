using System.Collections.Generic;
using Parking.Domain;
using Shiny.Mediator;

namespace Parking.Shiny.Publish.BestMatchCarPark;

internal sealed class BestMatchCarParkEvent(IEnumerable<CarPark> carParks) : IEvent
{
    public IEnumerable<CarPark> CarParks { get; } = carParks;
}
