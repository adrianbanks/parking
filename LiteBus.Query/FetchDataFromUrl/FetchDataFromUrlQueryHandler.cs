using System.Threading;
using System.Threading.Tasks;
using LiteBus.Queries.Abstractions;
using Parking.Domain;

namespace Parking.LiteBus.Query.FetchDataFromUrl;

internal sealed class FetchDataFromUrlQueryHandler : IQueryHandler<FetchDataFromUrlQuery, string>
{
    public async Task<string> HandleAsync(FetchDataFromUrlQuery message, CancellationToken cancellationToken)
    {
        var data = await DataFetcher.FetchData(message.Url);
        return await Task.FromResult(data);
    }
}
