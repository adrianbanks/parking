using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using LiteBus.Queries.Abstractions;
using Parking.Domain;

namespace Parking.LiteBus.Query.ParseCarParksFromData;

internal sealed class ParseCarParksFromDataQueryHandler : IQueryHandler<ParseCarParksFromDataQuery, IEnumerable<CarPark>>
{
    public async Task<IEnumerable<CarPark>> HandleAsync(ParseCarParksFromDataQuery message, CancellationToken cancellationToken)
    {
        var carParks = CarParkParser.Parse(message.Data);
        return await Task.FromResult(carParks);
    }
}
