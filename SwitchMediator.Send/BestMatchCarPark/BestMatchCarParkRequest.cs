using System.Collections.Generic;
using Mediator.Switch;
using Parking.Domain;

namespace Parking.SwitchMediator.Send.BestMatchCarPark;

[RequestHandler(typeof(BestMatchCarParkRequestHandler))]
internal sealed class BestMatchCarParkRequest(IEnumerable<CarPark> carParks) : IRequest<CarPark>
{
    public IEnumerable<CarPark> CarParks { get; } = carParks;
}
