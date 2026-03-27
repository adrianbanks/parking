using Mediator.Switch;

namespace Parking.SwitchMediator.ValuePublish.FetchDataFromUrl;

internal class FetchDataFromUrlEvent(string url) : INotification
{
    public string Url { get; } = url;
}
