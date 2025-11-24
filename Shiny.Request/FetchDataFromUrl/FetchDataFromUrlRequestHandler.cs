using System.Threading;
using System.Threading.Tasks;
using Parking.Domain;
using Shiny.Mediator;

namespace Parking.Shiny.Request.FetchDataFromUrl;

internal sealed class FetchDataFromUrlRequestHandler : IRequestHandler<FetchDataFromUrlRequest, string>
{
    public async Task<string> Handle(FetchDataFromUrlRequest request, IMediatorContext context, CancellationToken cancellationToken)
    {
        return await DataFetcher.FetchData(request.Url);
    }
}
