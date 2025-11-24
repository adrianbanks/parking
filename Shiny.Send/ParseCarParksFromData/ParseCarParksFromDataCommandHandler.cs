using System.Threading;
using System.Threading.Tasks;
using Parking.Domain;
using Parking.Shiny.Send.BestMatchCarPark;
using Shiny.Mediator;

namespace Parking.Shiny.Send.ParseCarParksFromData;

internal sealed class ParseCarParksFromDataCommandHandler : ICommandHandler<ParseCarParksFromDataCommand>
{
    public async Task Handle(ParseCarParksFromDataCommand command, IMediatorContext context, CancellationToken cancellationToken)
    {
        var carParks = CarParkParser.Parse(command.Data);
        await context.Send(new BestMatchCarParkCommand(carParks), cancellationToken);
    }
}
