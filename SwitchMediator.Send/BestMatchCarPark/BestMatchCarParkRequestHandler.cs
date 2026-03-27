using System.Threading;
using System.Threading.Tasks;
using Mediator.Switch;
using Parking.Domain;

namespace Parking.SwitchMediator.Send.BestMatchCarPark;

internal sealed class BestMatchCarParkRequestHandler : IRequestHandler<BestMatchCarParkRequest, CarPark>
{
    public Task<CarPark> Handle(BestMatchCarParkRequest request, CancellationToken cancellationToken)
    {
        var bestCarPark = BestMatchCalculator.CalculateBestMatch(request.CarParks);
        return Task.FromResult(bestCarPark);
    }
}
