using Shiny.Mediator;

namespace Parking.Shiny.Publish.ParseCarParksFromData;

internal sealed class ParseCarParksFromDataEvent(string data) : IEvent
{
    public string Data { get; } = data;
}
