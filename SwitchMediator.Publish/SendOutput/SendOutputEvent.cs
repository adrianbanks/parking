using Mediator.Switch;

namespace Parking.SwitchMediator.Publish.SendOutput;

internal sealed class SendOutputEvent(string output) : INotification
{
    public string Output { get; } = output;
}
