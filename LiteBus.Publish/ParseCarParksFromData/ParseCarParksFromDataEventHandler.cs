using System.Threading;
using System.Threading.Tasks;
using LiteBus.Events.Abstractions;
using Parking.Domain;
using Parking.LiteBus.Publish.BestMatchCarPark;

namespace Parking.LiteBus.Publish.ParseCarParksFromData;

internal sealed class ParseCarParksFromDataEventHandler(IEventPublisher publisher) : IEventHandler<ParseCarParksFromDataEvent>
{
    public async Task HandleAsync(ParseCarParksFromDataEvent message, CancellationToken cancellationToken)
    {
        var carParks = CarParkParser.Parse(message.Data);
        await publisher.PublishAsync(new BestMatchCarParkEvent(carParks), cancellationToken);
    }
}
