using Mediator;

namespace Parking.Mediator.Publish.FetchDataFromUrl;

internal class FetchDataFromUrlNotification(string url) : INotification
{
    public string Url { get; } = url;
}
