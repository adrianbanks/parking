using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using Mediator.Switch;
using Parking.Domain;

namespace Parking.SwitchMediator.Send.ParseCarParksFromData;

internal sealed class ParseCarParksFromDataRequestHandler : IRequestHandler<ParseCarParksFromDataRequest, IEnumerable<CarPark>>
{
    public Task<IEnumerable<CarPark>> Handle(ParseCarParksFromDataRequest request, CancellationToken cancellationToken)
    {
        var carParks = CarParkParser.Parse(request.Data);
        return Task.FromResult(carParks);
    }
}
