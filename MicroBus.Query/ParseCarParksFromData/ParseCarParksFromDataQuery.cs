using System.Collections.Generic;
using Enexure.MicroBus;
using Parking.Domain;

namespace Parking.MicroBus.Query.ParseCarParksFromData
{
    internal sealed class ParseCarParksFromDataQuery(string html) : IQuery<ParseCarParksFromDataQuery, IEnumerable<CarPark>>
    {
        public string Html { get; } = html;
    }
}
