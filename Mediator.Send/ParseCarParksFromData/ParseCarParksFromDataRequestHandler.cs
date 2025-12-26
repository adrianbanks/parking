using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using Mediator;
using Parking.Domain;

namespace Parking.Mediator.Send.ParseCarParksFromData;

internal sealed class ParseCarParksFromDataRequestHandler : IRequestHandler<ParseCarParksFromDataRequest, IEnumerable<CarPark>>
{
    public ValueTask<IEnumerable<CarPark>> Handle(ParseCarParksFromDataRequest request, CancellationToken cancellationToken)
    {
        var carParks = CarParkParser.Parse(request.Data);
        return ValueTask.FromResult(carParks);
    }
}
