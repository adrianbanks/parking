using System;
using System.Collections.Generic;
using Paramore.Brighter;
using Parking.Domain;

namespace Parking.Brighter.BestMatchCarPark
{
    internal sealed class BestMatchCarParkCommand : IRequest
    {
        public Guid Id { get; set; }
        public IEnumerable<CarPark> CarParks { get; }
        public CarPark BestMatch { get; set; }

        public BestMatchCarParkCommand(IEnumerable<CarPark> carParks)
        {
            Id = Guid.NewGuid();
            CarParks = carParks;
        }
    }
}
