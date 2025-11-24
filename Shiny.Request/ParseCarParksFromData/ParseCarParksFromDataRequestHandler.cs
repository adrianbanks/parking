using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using Parking.Domain;
using Shiny.Mediator;

namespace Parking.Shiny.Request.ParseCarParksFromData;

internal sealed class ParseCarParksFromDataRequestHandler : IRequestHandler<ParseCarParksFromDataRequest, IEnumerable<CarPark>>
{
    public Task<IEnumerable<CarPark>> Handle(ParseCarParksFromDataRequest request, IMediatorContext context, CancellationToken cancellationToken)
    {
        var carParks = CarParkParser.Parse(request.Data);
        return Task.FromResult(carParks);
    }
}
