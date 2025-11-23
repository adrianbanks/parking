using System.Threading;
using System.Threading.Tasks;
using Paramore.Brighter;
using Parking.Domain;

namespace Parking.Brighter.BestMatchCarPark;

internal sealed class BestMatchCarParkCommandHandler : RequestHandlerAsync<BestMatchCarParkCommand>
{
    public override async Task<BestMatchCarParkCommand> HandleAsync(BestMatchCarParkCommand command, CancellationToken cancellationToken = default)
    {
        var bestCarPark = BestMatchCalculator.CalculateBestMatch(command.CarParks);
        command.BestMatch = bestCarPark;
        return await base.HandleAsync(command, cancellationToken);
    }
}
