using System;
using System.Threading.Tasks;
using Parking.Domain;

namespace Parking.NoFramework;

public static class Program
{
    public static async Task Main()
    {
        var data = await DataFetcher.FetchData(SourceData.Url);
        var carParks = CarParkParser.Parse(data);
        var bestCarPark = BestMatchCalculator.CalculateBestMatch(carParks);
        var output = CarParkOutputFormatter.Format(bestCarPark);
        Console.WriteLine(output);
    }
}
