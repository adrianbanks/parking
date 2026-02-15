using LiteBus.Queries.Abstractions;

namespace Parking.LiteBus.Query.FetchDataFromUrl;

internal sealed class FetchDataFromUrlQuery(string url) : IQuery<string>
{
    public string Url { get; } = url;
}
