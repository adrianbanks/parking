using System;
using MediatR;

namespace Parking.Mediatr.Publish.SendOutput;

internal sealed class SendOutputNotificationHandler : NotificationHandler<SendOutputNotification>
{
    protected override void HandleCore(SendOutputNotification notification)
    {
        Console.WriteLine(notification.Output);
        Environment.Exit(0);
    }
}