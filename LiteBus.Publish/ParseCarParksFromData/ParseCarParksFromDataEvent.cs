using LiteBus.Events.Abstractions;

namespace Parking.LiteBus.Publish.ParseCarParksFromData;

internal sealed class ParseCarParksFromDataEvent(string data) : IEvent
{
    public string Data { get; } = data;
}
