using System.Collections.Generic;
using System.Threading.Tasks;
using Enexure.MicroBus;
using Parking.Domain;

namespace Parking.MicroBus.Query.ParseCarParksFromData
{
    internal sealed class ParseCarParksFromDataQueryHandler : IQueryHandler<ParseCarParksFromDataQuery, IEnumerable<CarPark>>
    {
        public async Task<IEnumerable<CarPark>> Handle(ParseCarParksFromDataQuery query)
        {
            var carParks = CarParkParser.Parse(query.Html);
            return await Task.FromResult(carParks);
        }
    }
}
