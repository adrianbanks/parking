using MediatR;
using Parking.Domain;

namespace Parking.Mediatr.Publish.CarParkToOutput;

internal sealed class CarParkToOutputNotification(CarPark carPark) : INotification
{
    public CarPark CarPark { get; } = carPark;
}