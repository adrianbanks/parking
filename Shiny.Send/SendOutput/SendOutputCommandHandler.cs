using System;
using System.Threading;
using System.Threading.Tasks;
using Shiny.Mediator;

namespace Parking.Shiny.Send.SendOutput;

internal sealed class SendOutputCommandHandler : ICommandHandler<SendOutputCommand>
{
    public Task Handle(SendOutputCommand command, IMediatorContext context, CancellationToken cancellationToken)
    {
        Console.WriteLine(command.Output);
        return Task.CompletedTask;
    }
}
