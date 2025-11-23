using System.Collections.Generic;
using System.Threading.Tasks;
using Enexure.MicroBus;
using Parking.Domain;

namespace Parking.MicroBus.Query.ParseDataFromHtml
{
    internal sealed class ParseDataFromHtmlQueryHandler : IQueryHandler<ParseDataFromHtmlQuery, IEnumerable<CarPark>>
    {
        public async Task<IEnumerable<CarPark>> Handle(ParseDataFromHtmlQuery query)
        {
            var carParks = CarParkParser.Parse(query.Html);
            return await Task.FromResult(carParks);
        }
    }
}
