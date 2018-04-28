using System.Collections.Generic;
using MediatR;
using Parking.Domain;

namespace Parking.Mediatr.Send.BestMatchCarPark
{
    internal sealed class BestMatchCarParkRequest : IRequest<CarPark>
    {
        public IEnumerable<CarPark> CarParks { get; }

        public BestMatchCarParkRequest(IEnumerable<CarPark> carParks)
        {
            CarParks = carParks;
        }
    }
}
