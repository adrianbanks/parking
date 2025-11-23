using MediatR;

namespace Parking.Mediatr.Publish.SendOutput;

public sealed class SendOutputNotification(string output) : INotification
{
    public string Output { get; } = output;
}