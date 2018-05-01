using System.Collections.Generic;
using MediatR;
using Parking.Domain;

namespace Parking.Mediatr.Publish.BestMatchCarPark
{
    internal sealed class BestMatchCarParkNotification : INotification
    {
        public IEnumerable<CarPark> CarParks { get; }

        public BestMatchCarParkNotification(IEnumerable<CarPark> carParks)
        {
            CarParks = carParks;
        }
    }
}
