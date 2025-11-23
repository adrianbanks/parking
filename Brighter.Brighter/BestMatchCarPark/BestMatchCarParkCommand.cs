using System.Collections.Generic;
using Paramore.Brighter;
using Parking.Domain;

namespace Parking.Brighter.Brighter.BestMatchCarPark;

internal sealed class BestMatchCarParkCommand(IEnumerable<CarPark> carParks) : Command(Id.Random())
{
    public IEnumerable<CarPark> CarParks { get; } = carParks;
    public CarPark BestMatch { get; set; }
}
