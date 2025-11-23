using System.Collections.Generic;
using Enexure.MicroBus;
using Parking.Domain;

namespace Parking.MicroBus.Query.ParseCarParksFromData;

internal sealed class ParseCarParksFromDataQuery(string data) : IQuery<ParseCarParksFromDataQuery, IEnumerable<CarPark>>
{
    public string Data { get; } = data;
}
