using System;
using System.Threading;
using System.Threading.Tasks;
using Mediator.Switch;

namespace Parking.SwitchMediator.ValuePublish.SendOutput;

internal sealed class SendOutputEventHandler : IValueNotificationHandler<SendOutputEvent>
{
    public ValueTask Handle(SendOutputEvent notification, CancellationToken cancellationToken)
    {
        Console.WriteLine(notification.Output);
        return ValueTask.CompletedTask;
    }
}
