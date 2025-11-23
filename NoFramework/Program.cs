using System;
using System.Threading.Tasks;
using Parking.Domain;

namespace Parking.NoFramework
{
    internal static class Program
    {
        internal static async Task Main()
        {
            var data = await DataFetcher.FetchData(SourceData.Url);
            var carParks = CarParkParser.Parse(data);
            var bestMatch = BestMatchCalculator.CalculateBestMatch(carParks);
            var output = CarParkOutputFormatter.Format(bestMatch);
            Console.WriteLine(output);
        }
    }
}
