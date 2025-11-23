using System;
using System.Collections.Generic;
using Paramore.Brighter;
using Parking.Domain;

namespace Parking.Brighter.ParseCarParksFromData
{
    internal sealed class ParseCarParksFromDataCommand : IRequest
    {
        public Guid Id { get; set; }
        public string Html { get; }
        public IEnumerable<CarPark> CarParks { get; set; }

        public ParseCarParksFromDataCommand(string html)
        {
            Id = Guid.NewGuid();
            Html = html;
        }
    }
}
