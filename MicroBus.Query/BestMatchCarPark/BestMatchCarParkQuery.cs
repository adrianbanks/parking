using System.Collections.Generic;
using Enexure.MicroBus;
using Parking.Domain;

namespace Parking.MicroBus.Query.BestMatchCarPark;

internal sealed class BestMatchCarParkQuery(IEnumerable<CarPark> carParks) : IQuery<BestMatchCarParkQuery, CarPark>
{
    public IEnumerable<CarPark> CarParks { get; } = carParks;
}