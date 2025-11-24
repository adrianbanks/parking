using System.Threading;
using System.Threading.Tasks;
using Parking.Domain;
using Parking.Shiny.Send.CarParkToOutput;
using Shiny.Mediator;

namespace Parking.Shiny.Send.BestMatchCarPark;

internal sealed class BestMatchCarParkCommandHandler : ICommandHandler<BestMatchCarParkCommand>
{
    public async Task Handle(BestMatchCarParkCommand command, IMediatorContext context, CancellationToken cancellationToken)
    {
        var bestCarPark = BestMatchCalculator.CalculateBestMatch(command.CarParks);
        await context.Send(new CarParkToOutputCommand(bestCarPark), cancellationToken);
    }
}
