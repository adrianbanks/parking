using System.Threading;
using System.Threading.Tasks;
using Mediator;
using Parking.Domain;

namespace Parking.Mediator.Send.CarParkToOutput;

internal sealed class CarParkToOutputRequestHandler : IRequestHandler<CarParkToOutputRequest, string>
{
    public ValueTask<string> Handle(CarParkToOutputRequest request, CancellationToken cancellationToken)
    {
        var output = CarParkOutputFormatter.Format(request.CarPark);
        return ValueTask.FromResult(output);
    }
}
