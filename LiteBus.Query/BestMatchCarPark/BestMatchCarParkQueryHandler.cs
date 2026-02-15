using System.Threading;
using System.Threading.Tasks;
using LiteBus.Queries.Abstractions;
using Parking.Domain;

namespace Parking.LiteBus.Query.BestMatchCarPark;

internal sealed class BestMatchCarParkQueryHandler : IQueryHandler<BestMatchCarParkQuery, CarPark>
{
    public async Task<CarPark> HandleAsync(BestMatchCarParkQuery message, CancellationToken cancellationToken)
    {
        var bestCarPark = BestMatchCalculator.CalculateBestMatch(message.CarParks);
        return await Task.FromResult(bestCarPark);
    }
}
