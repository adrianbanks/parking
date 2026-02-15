using System.Threading;
using System.Threading.Tasks;
using LiteBus.Events.Abstractions;
using Parking.Domain;
using Parking.LiteBus.Publish.CarParkToOutput;

namespace Parking.LiteBus.Publish.BestMatchCarPark;

internal sealed class BestMatchCarParkEventHandler(IEventPublisher publisher) : IEventHandler<BestMatchCarParkEvent>
{
    public async Task HandleAsync(BestMatchCarParkEvent message, CancellationToken cancellationToken)
    {
        var bestCarPark = BestMatchCalculator.CalculateBestMatch(message.CarParks);
        await publisher.PublishAsync(new CarParkToOutputEvent(bestCarPark), cancellationToken);
    }
}
