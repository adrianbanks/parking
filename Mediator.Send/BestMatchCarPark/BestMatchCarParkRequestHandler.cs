using System.Threading;
using System.Threading.Tasks;
using Mediator;
using Parking.Domain;

namespace Parking.Mediator.Send.BestMatchCarPark;

internal sealed class BestMatchCarParkRequestHandler : IRequestHandler<BestMatchCarParkRequest, CarPark>
{
    public ValueTask<CarPark> Handle(BestMatchCarParkRequest request, CancellationToken cancellationToken)
    {
        var bestCarPark = BestMatchCalculator.CalculateBestMatch(request.CarParks);
        return ValueTask.FromResult(bestCarPark);
    }
}
