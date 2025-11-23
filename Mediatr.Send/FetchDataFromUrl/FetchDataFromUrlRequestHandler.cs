using System.Threading.Tasks;
using MediatR;
using Parking.Domain;

namespace Parking.Mediatr.Send.FetchDataFromUrl;

internal sealed class FetchDataFromUrlRequestHandler : AsyncRequestHandler<FetchDataFromUrlRequest, string>
{
    protected override async Task<string> HandleCore(FetchDataFromUrlRequest request)
    {
        return await DataFetcher.FetchData(request.Url);
    }
}