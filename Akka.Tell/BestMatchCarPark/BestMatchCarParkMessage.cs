using System.Collections.Generic;
using Parking.Domain;

namespace Parking.Akka.Tell.BestMatchCarPark
{
    internal sealed class BestMatchCarParkMessage
    {
        public IEnumerable<CarPark> CarParks { get; }

        public BestMatchCarParkMessage(IEnumerable<CarPark> carParks)
        {
            CarParks = carParks;
        }
    }
}
