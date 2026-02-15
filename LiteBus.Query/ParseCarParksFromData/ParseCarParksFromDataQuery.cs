using System.Collections.Generic;
using LiteBus.Queries.Abstractions;
using Parking.Domain;

namespace Parking.LiteBus.Query.ParseCarParksFromData;

internal sealed class ParseCarParksFromDataQuery(string data) : IQuery<IEnumerable<CarPark>>
{
    public string Data { get; } = data;
}
