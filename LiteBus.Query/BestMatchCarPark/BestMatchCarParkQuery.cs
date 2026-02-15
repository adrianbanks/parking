using System.Collections.Generic;
using LiteBus.Queries.Abstractions;
using Parking.Domain;

namespace Parking.LiteBus.Query.BestMatchCarPark;

internal sealed class BestMatchCarParkQuery(IEnumerable<CarPark> carParks) : IQuery<CarPark>
{
    public IEnumerable<CarPark> CarParks { get; } = carParks;
}
