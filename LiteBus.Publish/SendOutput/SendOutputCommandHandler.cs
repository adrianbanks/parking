using System;
using System.Threading;
using System.Threading.Tasks;
using LiteBus.Events.Abstractions;

namespace Parking.LiteBus.Publish.SendOutput;

internal sealed class SendOutputEventHandler : IEventHandler<SendOutputEvent>
{
    public Task HandleAsync(SendOutputEvent message, CancellationToken cancellationToken)
    {
        Console.WriteLine(message.Output);
        return Task.CompletedTask;
    }
}
