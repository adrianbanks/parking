using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;

namespace Parking.Domain;

public static class DataFetcher
{
    public static async Task<string> FetchData(string url)
    {
        using var httpClient = new HttpClient();

        var body = new StringContent(
            """["Grafton East","Grafton West","Grand Arcade","Park Street","Queen Anne"]""",
            new MediaTypeHeaderValue("application/json"));

        var response = await httpClient.PostAsync(url, body);
        return await response.Content.ReadAsStringAsync();
    }
}