using System.Threading;
using System.Threading.Tasks;
using Paramore.Brighter;
using Parking.Domain;

namespace Parking.Brighter.FetchDataFromUrl
{
    internal sealed class FetchDataFromUrlRequestHandler : RequestHandlerAsync<FetchDataFromUrlCommand>
    {
        public override async Task<FetchDataFromUrlCommand> HandleAsync(FetchDataFromUrlCommand command, CancellationToken cancellationToken = new CancellationToken())
        {
            var html = await DataFetcher.FetchData(command.Url);
            command.Html = html;
            return await base.HandleAsync(command, cancellationToken);
        }
    }
}
