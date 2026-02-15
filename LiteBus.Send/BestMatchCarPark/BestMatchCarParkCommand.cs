using System.Collections.Generic;
using LiteBus.Commands.Abstractions;
using Parking.Domain;

namespace Parking.LiteBus.Send.BestMatchCarPark;

internal sealed class BestMatchCarParkCommand(IEnumerable<CarPark> carParks) : ICommand
{
    public IEnumerable<CarPark> CarParks { get; } = carParks;
}
