using Enexure.MicroBus;

namespace Parking.MicroBus.Query.FetchDataFromUrl
{
    internal sealed class FetchDataFromUrlQuery(string url) : IQuery<FetchDataFromUrlQuery, string>
    {
        public string Url { get; } = url;
    }
}
