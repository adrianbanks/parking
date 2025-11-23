using System.Threading;
using System.Threading.Tasks;
using Paramore.Darker;
using Parking.Domain;

namespace Parking.Brighter.Darker.FetchDataFromUrl;

internal sealed class FetchDataFromUrlQueryHandler : QueryHandlerAsync<FetchDataFromUrlQuery, string>
{
    public override async Task<string> ExecuteAsync(FetchDataFromUrlQuery query, CancellationToken cancellationToken = default)
    {
        return await DataFetcher.FetchData(query.Url);
    }
}
