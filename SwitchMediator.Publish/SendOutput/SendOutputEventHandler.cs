using System;
using System.Threading;
using System.Threading.Tasks;
using Mediator.Switch;

namespace Parking.SwitchMediator.Publish.SendOutput;

internal sealed class SendOutputEventHandler : INotificationHandler<SendOutputEvent>
{
    public Task Handle(SendOutputEvent notification, CancellationToken cancellationToken)
    {
        Console.WriteLine(notification.Output);
        return Task.CompletedTask;
    }
}
