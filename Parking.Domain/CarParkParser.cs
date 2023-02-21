using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using HtmlAgilityPack;

namespace Parking.Domain
{
    public static class CarParkParser
    {
        public static IEnumerable<CarPark> ParseFromHtml(string html)
        {
            var document = new HtmlDocument();
            document.LoadHtml(html);

            var carParkNames = document.DocumentNode
                .SelectNodes("//div[@class='col-md-12 main-content mt-3 print-full-width']/h3")
                .Select(n => n.InnerText)
                .ToList();

            var carParkSpaces = document.DocumentNode
                .SelectNodes("//div[@class='col-md-12 main-content mt-3 print-full-width']/p/b/text()[contains(.,'spaces')]")
                .Select(n => n.InnerText)
                .ToList();

            var carParkFillingData = document.DocumentNode
                .SelectNodes("//div[@class='col-md-12 main-content mt-3 print-full-width']/p/b/text()[not(contains(.,'spaces'))]")
                .Select(n => n.InnerText)
                .ToList();

            var carParks = new List<CarPark>();

            foreach (var carParkData in carParkNames.Select((name, index) => new { name, index }))
            {
                var name = ParseName(carParkData.name);
                var numberOfFreeSpaces = ParseFreeSpaces(carParkSpaces[carParkData.index]);
                var percentFull = numberOfFreeSpaces == 0 ? 100 : ParseFullData(carParkFillingData[carParkData.index]);

                var carPark = new CarPark(name, numberOfFreeSpaces, percentFull);
                carParks.Add(carPark);
            }

            return carParks;
        }

        private static string ParseName(string name)
        {
            var end = name.IndexOf(" car park", StringComparison.Ordinal);
            return end == -1 ? name.Replace("&amp;", "and") : name.Substring(0, end);
        }

        private static int ParseFreeSpaces(string carParkSpaceData)
        {
            if (carParkSpaceData == "This car park is full")
            {
                return 0;
            }

            var regex = new Regex(@"(?<spaces>\d*?) spaces");
            var match = regex.Match(carParkSpaceData);
            var spacesValue = match.Groups["spaces"].Value;
            return int.Parse(spacesValue);
        }

        private static int ParseFullData(string fullData)
        {
            var percent = fullData.TrimEnd('%');
            return int.Parse(percent);
        }
    }
}
