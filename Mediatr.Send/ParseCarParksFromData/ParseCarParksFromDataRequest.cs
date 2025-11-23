using System.Collections.Generic;
using MediatR;
using Parking.Domain;

namespace Parking.Mediatr.Send.ParseCarParksFromData
{
    internal sealed class ParseCarParksFromDataRequest(string html) : IRequest<IEnumerable<CarPark>>
    {
        public string Html { get; } = html;
    }
}
