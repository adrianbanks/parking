using Paramore.Darker;

namespace Parking.Brighter.Darker.FetchDataFromUrl;

internal sealed class FetchDataFromUrlQuery(string url) : IQuery<string>
{
    public string Url { get; } = url;
}
