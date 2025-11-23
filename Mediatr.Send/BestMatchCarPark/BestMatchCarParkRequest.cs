using System.Collections.Generic;
using MediatR;
using Parking.Domain;

namespace Parking.Mediatr.Send.BestMatchCarPark
{
    internal sealed class BestMatchCarParkRequest(IEnumerable<CarPark> carParks) : IRequest<CarPark>
    {
        public IEnumerable<CarPark> CarParks { get; } = carParks;
    }
}
