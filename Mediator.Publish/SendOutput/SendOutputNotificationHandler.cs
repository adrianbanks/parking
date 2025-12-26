using System;
using System.Threading;
using System.Threading.Tasks;
using Mediator;

namespace Parking.Mediator.Publish.SendOutput;

internal sealed class SendOutputNotificationHandler : INotificationHandler<SendOutputNotification>
{
    public ValueTask Handle(SendOutputNotification notification, CancellationToken cancellationToken)
    {
        Console.WriteLine(notification.Output);
        return ValueTask.CompletedTask;
    }
}
