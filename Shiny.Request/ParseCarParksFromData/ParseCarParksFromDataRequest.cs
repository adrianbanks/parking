using System.Collections.Generic;
using Parking.Domain;
using Shiny.Mediator;

namespace Parking.Shiny.Request.ParseCarParksFromData;

internal sealed class ParseCarParksFromDataRequest(string data) : IRequest<IEnumerable<CarPark>>
{
    public string Data { get; } = data;
}
