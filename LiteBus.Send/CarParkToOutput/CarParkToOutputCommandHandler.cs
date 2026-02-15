using System.Threading;
using System.Threading.Tasks;
using LiteBus.Commands.Abstractions;
using Parking.Domain;
using Parking.LiteBus.Send.SendOutput;

namespace Parking.LiteBus.Send.CarParkToOutput;

internal sealed class CarParkToOutputCommandHandler(ICommandMediator mediator) : ICommandHandler<CarParkToOutputCommand>
{
    public async Task HandleAsync(CarParkToOutputCommand message, CancellationToken cancellationToken)
    {
        var output = CarParkOutputFormatter.Format(message.BestMatch);
        await mediator.SendAsync(new SendOutputCommand(output), cancellationToken);
    }
}
