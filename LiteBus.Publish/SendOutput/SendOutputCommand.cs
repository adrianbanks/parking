using LiteBus.Events.Abstractions;

namespace Parking.LiteBus.Publish.SendOutput;

internal sealed class SendOutputEvent(string output) : IEvent
{
    public string Output { get; } = output;
}
