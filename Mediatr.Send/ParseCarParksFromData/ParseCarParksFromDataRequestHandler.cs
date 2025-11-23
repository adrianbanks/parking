using System.Collections.Generic;
using System.Threading.Tasks;
using MediatR;
using Parking.Domain;

namespace Parking.Mediatr.Send.ParseCarParksFromData
{
    internal sealed class ParseCarParksFromDataRequestHandler : AsyncRequestHandler<ParseCarParksFromDataRequest, IEnumerable<CarPark>>
    {
        protected override Task<IEnumerable<CarPark>> HandleCore(ParseCarParksFromDataRequest request)
        {
            var carParks = CarParkParser.Parse(request.Data);
            return Task.FromResult(carParks);
        }
    }
}
