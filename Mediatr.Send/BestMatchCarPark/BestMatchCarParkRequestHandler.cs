using System.Threading.Tasks;
using MediatR;
using Parking.Domain;

namespace Parking.Mediatr.Send.BestMatchCarPark
{
    internal sealed class BestMatchCarParkRequestHandler : AsyncRequestHandler<BestMatchCarParkRequest, CarPark>
    {
        protected override Task<CarPark> HandleCore(BestMatchCarParkRequest request)
        {
            var bestCarPark = BestMatchCalculator.CalculateBestMatch(request.CarParks);
            return Task.FromResult(bestCarPark);
        }
    }
}
