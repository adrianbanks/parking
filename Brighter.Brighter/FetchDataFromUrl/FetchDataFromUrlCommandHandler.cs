using System.Threading;
using System.Threading.Tasks;
using Paramore.Brighter;
using Parking.Domain;

namespace Parking.Brighter.Brighter.FetchDataFromUrl;

internal sealed class FetchDataFromUrlCommandHandler : RequestHandlerAsync<FetchDataFromUrlCommand>
{
    public override async Task<FetchDataFromUrlCommand> HandleAsync(FetchDataFromUrlCommand command, CancellationToken cancellationToken = default)
    {
        command.Data = await DataFetcher.FetchData(command.Url);
        return await base.HandleAsync(command, cancellationToken);
    }
}
