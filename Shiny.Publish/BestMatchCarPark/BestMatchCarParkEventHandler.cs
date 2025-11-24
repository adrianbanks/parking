using System.Threading;
using System.Threading.Tasks;
using Parking.Domain;
using Parking.Shiny.Publish.CarParkToOutput;
using Shiny.Mediator;

namespace Parking.Shiny.Publish.BestMatchCarPark;

internal sealed class BestMatchCarParkEventHandler : IEventHandler<BestMatchCarParkEvent>
{
    public async Task Handle(BestMatchCarParkEvent @event, IMediatorContext context, CancellationToken cancellationToken)
    {
        var bestCarPark = BestMatchCalculator.CalculateBestMatch(@event.CarParks);
        await context.Publish(new CarParkToOutputEvent(bestCarPark), cancellationToken: cancellationToken);
    }
}
