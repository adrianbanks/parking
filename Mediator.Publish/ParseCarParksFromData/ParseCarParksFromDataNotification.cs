using Mediator;

namespace Parking.Mediator.Publish.ParseCarParksFromData;

internal sealed class ParseCarParksFromDataNotification(string data) : INotification
{
    public string Data { get; } = data;
}
