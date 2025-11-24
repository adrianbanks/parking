using Shiny.Mediator;

namespace Parking.Shiny.Publish.FetchDataFromUrl;

internal class FetchDataFromUrlEvent(string url) : IEvent
{
    public string Url { get; } = url;
}
