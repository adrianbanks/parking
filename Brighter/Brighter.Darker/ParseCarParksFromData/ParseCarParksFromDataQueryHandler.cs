using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using Paramore.Darker;
using Parking.Domain;

namespace Parking.Brighter.Darker.ParseCarParksFromData;

internal sealed class ParseCarParksFromDataQueryHandler : QueryHandlerAsync<ParseCarParksFromDataQuery, IEnumerable<CarPark>>
{
    public override Task<IEnumerable<CarPark>> ExecuteAsync(ParseCarParksFromDataQuery query, CancellationToken cancellationToken = default)
    {
        var carParks = CarParkParser.Parse(query.Data);
        return Task.FromResult(carParks);
    }
}
