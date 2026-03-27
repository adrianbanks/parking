using Mediator.Switch;

namespace Parking.SwitchMediator.Publish.ParseCarParksFromData;

internal sealed class ParseCarParksFromDataEvent(string data) : INotification
{
    public string Data { get; } = data;
}
