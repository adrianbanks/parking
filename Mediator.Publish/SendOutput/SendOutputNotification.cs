using Mediator;

namespace Parking.Mediator.Publish.SendOutput;

public sealed class SendOutputNotification(string output) : INotification
{
    public string Output { get; } = output;
}
