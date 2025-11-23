using System.Collections.Generic;
using System.Threading.Tasks;
using MediatR;
using Parking.Domain;

namespace Parking.Mediatr.Send.ParseDataFromHtml
{
    internal sealed class ParseDataFromHtmlRequestHandler : AsyncRequestHandler<ParseDataFromHtmlRequest, IEnumerable<CarPark>>
    {
        protected override Task<IEnumerable<CarPark>> HandleCore(ParseDataFromHtmlRequest request)
        {
            var carParks = CarParkParser.Parse(request.Html);
            return Task.FromResult(carParks);
        }
    }
}
