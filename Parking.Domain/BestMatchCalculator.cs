using System.Collections.Generic;
using System.Linq;

namespace Parking.Domain;

public static class BestMatchCalculator
{
    public static CarPark CalculateBestMatch(IEnumerable<CarPark> carParks)
    {
        return carParks.OrderByDescending(p => p.NumberOfFreeSpaces)
            .ThenBy(p => p.Name)
            .First();
    }
}
