using System.Collections.Generic;
using MediatR;
using Parking.Domain;

namespace Parking.Mediatr.Send.ParseCarParksFromData
{
    internal sealed class ParseCarParksFromDataRequest : IRequest<IEnumerable<CarPark>>
    {
        public string Html { get; }

        public ParseCarParksFromDataRequest(string html)
        {
            Html = html;
        }
    }
}
