using System;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;

namespace Parking.Domain
{
    public static class DataFetcher
    {
        public static async Task<string> FetchData(string url)
        {
            const string userAgent = "Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/66.0.3359.181 Safari/537.36";

            var cookieContainer = new CookieContainer();
            cookieContainer.Add(new Cookie("Accept", "*/*", "/", new Uri(url).Host));

            using (var handler = new HttpClientHandler { CookieContainer = cookieContainer })
            using (var httpClient = new HttpClient(handler))
            {
                httpClient.DefaultRequestHeaders.Add("User-Agent", userAgent);
                var response = await httpClient.GetAsync(url);
                return await response.Content.ReadAsStringAsync();
            }
        }
    }
}
