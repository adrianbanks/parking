using System.Threading;
using System.Threading.Tasks;
using LiteBus.Commands.Abstractions;
using Parking.Domain;
using Parking.LiteBus.Send.CarParkToOutput;

namespace Parking.LiteBus.Send.BestMatchCarPark;

internal sealed class BestMatchCarParkCommandHandler(ICommandMediator mediator) : ICommandHandler<BestMatchCarParkCommand>
{
    public async Task HandleAsync(BestMatchCarParkCommand message, CancellationToken cancellationToken)
    {
        var bestCarPark = BestMatchCalculator.CalculateBestMatch(message.CarParks);
        await mediator.SendAsync(new CarParkToOutputCommand(bestCarPark), cancellationToken);
    }
}
