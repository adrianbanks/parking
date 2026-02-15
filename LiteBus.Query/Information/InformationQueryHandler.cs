using System.Threading;
using System.Threading.Tasks;
using LiteBus.Queries.Abstractions;
using Parking.Domain;
using Parking.LiteBus.Query.BestMatchCarPark;
using Parking.LiteBus.Query.CarParkToOutput;
using Parking.LiteBus.Query.FetchDataFromUrl;
using Parking.LiteBus.Query.ParseCarParksFromData;

namespace Parking.LiteBus.Query.Information;

internal sealed class InformationQueryHandler(IQueryMediator mediator) : IQueryHandler<InformationQuery, string>
{
    public async Task<string> HandleAsync(InformationQuery message, CancellationToken cancellationToken)
    {
        var data = await mediator.QueryAsync(new FetchDataFromUrlQuery(SourceData.Url), cancellationToken);
        var carParkData = await mediator.QueryAsync(new ParseCarParksFromDataQuery(data), cancellationToken);
        var bestCarPark = await mediator.QueryAsync(new BestMatchCarParkQuery(carParkData), cancellationToken);
        return await mediator.QueryAsync(new CarParkToOutputQuery(bestCarPark), cancellationToken);
    }
}
