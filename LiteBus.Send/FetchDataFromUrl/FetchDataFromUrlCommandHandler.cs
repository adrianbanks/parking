using System.Threading;
using System.Threading.Tasks;
using LiteBus.Commands.Abstractions;
using Parking.Domain;
using Parking.LiteBus.Send.ParseCarParksFromData;

namespace Parking.LiteBus.Send.FetchDataFromUrl;

internal sealed class FetchDataFromUrlCommandHandler(ICommandMediator mediator) : ICommandHandler<FetchDataFromUrlCommand>
{
    public async Task HandleAsync(FetchDataFromUrlCommand message, CancellationToken cancellationToken)
    {
        var data = await DataFetcher.FetchData(message.Url);
        await mediator.SendAsync(new ParseCarParksFromDataCommand(data), cancellationToken);
    }
}
