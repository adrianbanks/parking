using System;
using System.Collections.Generic;
using Paramore.Brighter;
using Parking.Domain;

namespace Parking.Brighter.BestMatchCarPark
{
    internal sealed class BestMatchCarParkCommand(IEnumerable<CarPark> carParks) : IRequest
    {
        public Guid Id { get; set; } = Guid.NewGuid();
        public IEnumerable<CarPark> CarParks { get; } = carParks;
        public CarPark BestMatch { get; set; }
    }
}
