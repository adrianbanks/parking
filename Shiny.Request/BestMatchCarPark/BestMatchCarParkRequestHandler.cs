using System.Threading;
using System.Threading.Tasks;
using Parking.Domain;
using Shiny.Mediator;

namespace Parking.Shiny.Request.BestMatchCarPark;

internal sealed class BestMatchCarParkRequestHandler : IRequestHandler<BestMatchCarParkRequest, CarPark>
{
    public Task<CarPark> Handle(BestMatchCarParkRequest request, IMediatorContext context, CancellationToken cancellationToken)
    {
        var bestCarPark = BestMatchCalculator.CalculateBestMatch(request.CarParks);
        return Task.FromResult(bestCarPark);
    }
}
