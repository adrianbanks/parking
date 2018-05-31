using Enexure.MicroBus;

namespace Parking.MicroBus.Query.FetchDataFromUrl
{
    internal sealed class FetchDataFromUrlQuery : IQuery<FetchDataFromUrlQuery, string>
    {
        public string Url { get; }

        public FetchDataFromUrlQuery(string url)
        {
            Url = url;
        }
    }
}
