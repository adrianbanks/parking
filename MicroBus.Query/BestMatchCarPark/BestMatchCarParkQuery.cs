using System.Collections.Generic;
using Enexure.MicroBus;
using Parking.Domain;

namespace Parking.MicroBus.Query.BestMatchCarPark
{
    internal sealed class BestMatchCarParkQuery : IQuery<BestMatchCarParkQuery, CarPark>
    {
        public IEnumerable<CarPark> CarParks { get; }

        public BestMatchCarParkQuery(IEnumerable<CarPark> carParks)
        {
            CarParks = carParks;
        }
    }
}
