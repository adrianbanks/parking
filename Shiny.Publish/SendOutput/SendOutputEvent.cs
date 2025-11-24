using Shiny.Mediator;

namespace Parking.Shiny.Publish.SendOutput;

internal sealed class SendOutputEvent(string output) : IEvent
{
    public string Output { get; } = output;
}
