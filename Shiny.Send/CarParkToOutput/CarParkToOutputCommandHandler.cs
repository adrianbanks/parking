using System.Threading;
using System.Threading.Tasks;
using Parking.Domain;
using Parking.Shiny.Send.SendOutput;
using Shiny.Mediator;

namespace Parking.Shiny.Send.CarParkToOutput;

internal sealed class CarParkToOutputCommandHandler : ICommandHandler<CarParkToOutputCommand>
{
    public async Task Handle(CarParkToOutputCommand command, IMediatorContext context, CancellationToken cancellationToken)
    {
        var output = CarParkOutputFormatter.Format(command.CarPark);
        await context.Send(new SendOutputCommand(output), cancellationToken);
    }
}
