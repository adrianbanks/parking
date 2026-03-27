using Mediator.Switch;

namespace Parking.SwitchMediator.ValuePublish.ParseCarParksFromData;

internal sealed class ParseCarParksFromDataEvent(string data) : INotification
{
    public string Data { get; } = data;
}
