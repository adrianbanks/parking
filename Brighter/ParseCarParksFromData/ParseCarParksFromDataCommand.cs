using System;
using System.Collections.Generic;
using Paramore.Brighter;
using Parking.Domain;

namespace Parking.Brighter.ParseCarParksFromData
{
    internal sealed class ParseCarParksFromDataCommand(string html) : IRequest
    {
        public Guid Id { get; set; } = Guid.NewGuid();
        public string Html { get; } = html;
        public IEnumerable<CarPark> CarParks { get; set; }
    }
}
