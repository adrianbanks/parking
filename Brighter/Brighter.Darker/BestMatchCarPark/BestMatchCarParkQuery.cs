using System.Collections.Generic;
using Paramore.Darker;
using Parking.Domain;

namespace Parking.Brighter.Darker.BestMatchCarPark;

internal sealed class BestMatchCarParkQuery(IEnumerable<CarPark> carParks) : IQuery<CarPark>
{
    public IEnumerable<CarPark> CarParks { get; } = carParks;
}
