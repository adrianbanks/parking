using System.Collections.Generic;
using MediatR;
using Parking.Domain;

namespace Parking.Mediatr.Send.ParseCarParksFromData;

internal sealed class ParseCarParksFromDataRequest(string data) : IRequest<IEnumerable<CarPark>>
{
    public string Data { get; } = data;
}
