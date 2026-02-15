using System;
using System.Threading;
using System.Threading.Tasks;
using LiteBus.Commands.Abstractions;

namespace Parking.LiteBus.Send.SendOutput;

internal sealed class SendOutputCommandHandler : ICommandHandler<SendOutputCommand>
{
    public Task HandleAsync(SendOutputCommand message, CancellationToken cancellationToken)
    {
        Console.WriteLine(message.Output);
        return Task.CompletedTask;
    }
}
