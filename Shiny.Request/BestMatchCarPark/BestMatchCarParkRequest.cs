using System.Collections.Generic;
using Parking.Domain;
using Shiny.Mediator;

namespace Parking.Shiny.Request.BestMatchCarPark;

internal sealed class BestMatchCarParkRequest(IEnumerable<CarPark> carParks) : IRequest<CarPark>
{
    public IEnumerable<CarPark> CarParks { get; } = carParks;
}
