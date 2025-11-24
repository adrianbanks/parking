using System.Collections.Generic;
using Parking.Domain;
using Shiny.Mediator;

namespace Parking.Shiny.Send.BestMatchCarPark;

internal sealed class BestMatchCarParkCommand(IEnumerable<CarPark> carParks) : ICommand
{
    public IEnumerable<CarPark> CarParks { get; } = carParks;
}
