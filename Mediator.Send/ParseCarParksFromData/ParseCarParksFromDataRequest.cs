using System.Collections.Generic;
using Mediator;
using Parking.Domain;

namespace Parking.Mediator.Send.ParseCarParksFromData;

internal sealed class ParseCarParksFromDataRequest(string data) : IRequest<IEnumerable<CarPark>>
{
    public string Data { get; } = data;
}
