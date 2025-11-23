using System.Collections.Generic;
using Parking.Domain;

namespace Parking.Akka.Tell.BestMatchCarPark
{
    internal sealed class BestMatchCarParkMessage(IEnumerable<CarPark> carParks)
    {
        public IEnumerable<CarPark> CarParks { get; } = carParks;
    }
}
