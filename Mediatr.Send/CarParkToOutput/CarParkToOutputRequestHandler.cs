using System.Threading;
using System.Threading.Tasks;
using MediatR;
using Parking.Domain;

namespace Parking.Mediatr.Send.CarParkToOutput;

internal sealed class CarParkToOutputRequestHandler : IRequestHandler<CarParkToOutputRequest, string>
{
    public Task<string> Handle(CarParkToOutputRequest request, CancellationToken cancellationToken)
    {
        var output = CarParkOutputFormatter.Format(request.CarPark);
        return Task.FromResult(output);
    }
}
