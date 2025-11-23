using System.Threading;
using System.Threading.Tasks;
using Paramore.Darker;
using Parking.Domain;

namespace Parking.Brighter.Darker.BestMatchCarPark;

internal sealed class BestMatchCarParkQueryHandler : QueryHandlerAsync<BestMatchCarParkQuery, CarPark>
{
    public override Task<CarPark> ExecuteAsync(BestMatchCarParkQuery query, CancellationToken cancellationToken = default)
    {
        var bestMatch = BestMatchCalculator.CalculateBestMatch(query.CarParks);
        return Task.FromResult(bestMatch);
    }
}
