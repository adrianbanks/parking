using System.Threading.Tasks;
using Enexure.MicroBus;
using Parking.Domain;

namespace Parking.MicroBus.Query.BestMatchCarPark;

internal sealed class BestMatchCarParkQueryHandler : IQueryHandler<BestMatchCarParkQuery, CarPark>
{
    public async Task<CarPark> Handle(BestMatchCarParkQuery query)
    {
        var bestCarPark = BestMatchCalculator.CalculateBestMatch(query.CarParks);
        return await Task.FromResult(bestCarPark);
    }
}