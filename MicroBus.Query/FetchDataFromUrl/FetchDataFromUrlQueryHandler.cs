using System.Threading.Tasks;
using Enexure.MicroBus;
using Parking.Domain;

namespace Parking.MicroBus.Query.FetchDataFromUrl
{
    internal sealed class FetchDataFromUrlQueryHandler : IQueryHandler<FetchDataFromUrlQuery, string>
    {
        public async Task<string> Handle(FetchDataFromUrlQuery query)
        {
            var data = await DataFetcher.FetchData(query.Url);
            return await Task.FromResult(data);
        }
    }
}
