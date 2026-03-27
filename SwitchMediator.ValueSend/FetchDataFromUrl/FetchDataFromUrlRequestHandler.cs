using System.Threading;
using System.Threading.Tasks;
using Mediator.Switch;
using Parking.Domain;

namespace Parking.SwitchMediator.ValueSend.FetchDataFromUrl;

internal sealed class FetchDataFromUrlRequestHandler : IRequestHandler<FetchDataFromUrlRequest, string>
{
    public async Task<string> Handle(FetchDataFromUrlRequest request, CancellationToken cancellationToken)
    {
        return await DataFetcher.FetchData(request.Url);
    }
}
