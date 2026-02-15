using System.Threading;
using System.Threading.Tasks;
using LiteBus.Commands.Abstractions;
using Parking.Domain;
using Parking.LiteBus.Send.BestMatchCarPark;

namespace Parking.LiteBus.Send.ParseCarParksFromData;

internal sealed class ParseCarParksFromDataCommandHandler(ICommandMediator mediator) : ICommandHandler<ParseCarParksFromDataCommand>
{
    public async Task HandleAsync(ParseCarParksFromDataCommand message, CancellationToken cancellationToken)
    {
        var carParks = CarParkParser.Parse(message.Data);
        await mediator.SendAsync(new BestMatchCarParkCommand(carParks), cancellationToken);
    }
}
