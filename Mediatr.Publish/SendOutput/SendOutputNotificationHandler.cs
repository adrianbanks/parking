using System;
using System.Threading;
using System.Threading.Tasks;
using MediatR;

namespace Parking.Mediatr.Publish.SendOutput;

internal sealed class SendOutputNotificationHandler : INotificationHandler<SendOutputNotification>
{
    public Task Handle(SendOutputNotification notification, CancellationToken cancellationToken)
    {
        Console.WriteLine(notification.Output);
        Environment.Exit(0);
        return Task.CompletedTask;
    }
}
