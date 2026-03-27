using Mediator.Switch;

namespace Parking.SwitchMediator.ValuePublish.SendOutput;

internal sealed class SendOutputEvent(string output) : INotification
{
    public string Output { get; } = output;
}
