using System.Threading;
using System.Threading.Tasks;
using Parking.Domain;
using Parking.Shiny.Send.ParseCarParksFromData;
using Shiny.Mediator;

namespace Parking.Shiny.Send.FetchDataFromUrl;

internal sealed class FetchDataFromUrlCommandHandler : ICommandHandler<FetchDataFromUrlCommand>
{
    public async Task Handle(FetchDataFromUrlCommand command, IMediatorContext context, CancellationToken cancellationToken)
    {
        var data = await DataFetcher.FetchData(command.Url);
        await context.Send(new ParseCarParksFromDataCommand(data), cancellationToken);
    }
}
