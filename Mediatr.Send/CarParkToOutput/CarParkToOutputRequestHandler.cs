using System.Threading.Tasks;
using MediatR;
using Parking.Domain;

namespace Parking.Mediatr.Send.CarParkToOutput
{
    internal sealed class CarParkToOutputRequestHandler : AsyncRequestHandler<CarParkToOutputRequest, string>
    {
        protected override Task<string> HandleCore(CarParkToOutputRequest request)
        {
            var output = CarParkOutputFormatter.Format(request.CarPark);
            return Task.FromResult(output);
        }
    }
}
