using System.Collections.Generic;
using Mediator.Switch;
using Parking.Domain;

namespace Parking.SwitchMediator.ValueSend.ParseCarParksFromData;

[RequestHandler(typeof(ParseCarParksFromDataRequestHandler))]
internal sealed class ParseCarParksFromDataRequest(string data) : IRequest<IEnumerable<CarPark>>
{
    public string Data { get; } = data;
}
