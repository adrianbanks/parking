using System;
using System.Threading;
using System.Threading.Tasks;
using Shiny.Mediator;

namespace Parking.Shiny.Publish.SendOutput;

internal sealed class SendOutputEventHandler : IEventHandler<SendOutputEvent>
{
    public Task Handle(SendOutputEvent @event, IMediatorContext context, CancellationToken cancellationToken)
    {
        Console.WriteLine(@event.Output);
        return Task.CompletedTask;
    }
}
