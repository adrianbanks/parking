using System.Collections.Generic;
using Mediator;
using Parking.Domain;

namespace Parking.Mediator.Send.BestMatchCarPark;

internal sealed class BestMatchCarParkRequest(IEnumerable<CarPark> carParks) : IRequest<CarPark>
{
    public IEnumerable<CarPark> CarParks { get; } = carParks;
}
