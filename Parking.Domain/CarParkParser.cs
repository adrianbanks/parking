using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json;

namespace Parking.Domain
{
    public static class CarParkParser
    {
        public static IEnumerable<CarPark> Parse(string json)
        {
            var options = new JsonSerializerOptions { PropertyNameCaseInsensitive = true };
            var data = JsonSerializer.Deserialize<CarParkData[]>(json, options);
            return data.Select(d => new CarPark(d.Name,
                d.TotalSpaces - d.VacantSpaces,
                Convert.ToInt32(Math.Round(d.OccupiedPercentage))));
        }

        private sealed record CarParkData(string Name, int TotalSpaces, int VacantSpaces, double OccupiedPercentage);
    }
}
