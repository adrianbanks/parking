using Mediator.Switch;

namespace Parking.SwitchMediator.Publish.FetchDataFromUrl;

internal class FetchDataFromUrlEvent(string url) : INotification
{
    public string Url { get; } = url;
}
