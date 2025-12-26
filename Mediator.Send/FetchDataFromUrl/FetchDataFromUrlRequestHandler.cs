using System.Threading;
using System.Threading.Tasks;
using Mediator;
using Parking.Domain;

namespace Parking.Mediator.Send.FetchDataFromUrl;

internal sealed class FetchDataFromUrlRequestHandler : IRequestHandler<FetchDataFromUrlRequest, string>
{
    public async ValueTask<string> Handle(FetchDataFromUrlRequest request, CancellationToken cancellationToken)
    {
        return await DataFetcher.FetchData(request.Url);
    }
}
