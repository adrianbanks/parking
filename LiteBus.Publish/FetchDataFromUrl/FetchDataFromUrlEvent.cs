using LiteBus.Events.Abstractions;

namespace Parking.LiteBus.Publish.FetchDataFromUrl;

internal sealed class FetchDataFromUrlEvent(string url) : IEvent
{
    public string Url { get; } = url;
}
