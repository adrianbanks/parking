using System.Collections.Generic;
using Paramore.Darker;
using Parking.Domain;

namespace Parking.Brighter.Darker.ParseCarParksFromData;

internal sealed class ParseCarParksFromDataQuery(string data) : IQuery<IEnumerable<CarPark>>
{
    public string Data { get; } = data;
}
