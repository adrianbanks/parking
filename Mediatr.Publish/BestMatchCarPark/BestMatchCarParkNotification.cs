using System.Collections.Generic;
using MediatR;
using Parking.Domain;

namespace Parking.Mediatr.Publish.BestMatchCarPark;

internal sealed class BestMatchCarParkNotification(IEnumerable<CarPark> carParks) : INotification
{
    public IEnumerable<CarPark> CarParks { get; } = carParks;
}