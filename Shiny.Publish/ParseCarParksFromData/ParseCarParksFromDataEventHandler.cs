using System.Threading;
using System.Threading.Tasks;
using Parking.Domain;
using Parking.Shiny.Publish.BestMatchCarPark;
using Shiny.Mediator;

namespace Parking.Shiny.Publish.ParseCarParksFromData;

internal sealed class ParseCarParksFromDataEventHandler : IEventHandler<ParseCarParksFromDataEvent>
{
    public async Task Handle(ParseCarParksFromDataEvent @event, IMediatorContext context, CancellationToken cancellationToken)
    {
        var carParks = CarParkParser.Parse(@event.Data);
        await context.Publish(new BestMatchCarParkEvent(carParks), cancellationToken: cancellationToken);
    }
}
