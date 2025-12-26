using System;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;

namespace Parking.Domain;

public static class DataFetcher
{
    // set to false to fetch real data from the URL
    public static bool UseFakeData { get; set; } = true;

    private static string _fakeData;

    public static async Task<string> FetchData(string url)
    {
        return UseFakeData
            ? _fakeData ??= new FakeDataCreator().FakeData()
            : await FetchFromUrl(url);
    }

    private static async Task<string> FetchFromUrl(string url)
    {
        using var httpClient = new HttpClient();

        var body = new StringContent(
            """["Grafton East","Grafton West","Grand Arcade","Park Street","Queen Anne"]""",
            new MediaTypeHeaderValue("application/json"));

        var response = await httpClient.PostAsync(url, body);
        return await response.Content.ReadAsStringAsync();
    }

    private sealed class FakeDataCreator
    {
        private readonly Random _random = new();

        public string FakeData()
        {
            var graftonEast = CreateRandomFullness(780);
            var graftonWest = CreateRandomFullness(255);
            var grandArcade = CreateRandomFullness(900);
            var parkStreet = CreateRandomFullness(175);
            var queenAnne = CreateRandomFullness(515);

            return $$"""
                     [
                       {
                         "name": "Grafton East",
                         "totalSpaces": {{graftonEast.TotalSpaces}},
                         "vacantSpaces": {{graftonEast.VacantSpaces}},
                         "occupiedPercentage": {{graftonEast.OccupiedPercentage}}
                       },
                       {
                         "name": "Grafton West",
                         "totalSpaces": {{graftonWest.TotalSpaces}},
                         "vacantSpaces": {{graftonWest.VacantSpaces}},
                         "occupiedPercentage": {{graftonWest.OccupiedPercentage}}
                       },
                       {
                         "name": "Grand Arcade",
                         "totalSpaces": {{grandArcade.TotalSpaces}},
                         "vacantSpaces": {{grandArcade.VacantSpaces}},
                         "occupiedPercentage": {{grandArcade.OccupiedPercentage}}
                       },
                       {
                         "name": "Park Street",
                         "totalSpaces": {{parkStreet.TotalSpaces}},
                         "vacantSpaces": {{parkStreet.VacantSpaces}},
                         "occupiedPercentage": {{parkStreet.OccupiedPercentage}}
                       },
                       {
                         "name": "Queen Anne",
                         "totalSpaces": {{queenAnne.TotalSpaces}},
                         "vacantSpaces": {{queenAnne.VacantSpaces}},
                         "occupiedPercentage": {{queenAnne.OccupiedPercentage}}
                       }
                     ]
                     """;
        }

        private (int TotalSpaces, int VacantSpaces, int OccupiedPercentage) CreateRandomFullness(int totalSpaces)
        {
            var vacantSpaces = totalSpaces - _random.Next(1, totalSpaces);
            var percentageFull = Convert.ToInt32((double) (totalSpaces - vacantSpaces) / totalSpaces * 100);
            return (totalSpaces, vacantSpaces, percentageFull);
        }
    }
}
