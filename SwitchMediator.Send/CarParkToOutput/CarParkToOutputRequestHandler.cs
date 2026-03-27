using System.Threading;
using System.Threading.Tasks;
using Mediator.Switch;
using Parking.Domain;

namespace Parking.SwitchMediator.Send.CarParkToOutput;

internal sealed class CarParkToOutputRequestHandler : IRequestHandler<CarParkToOutputRequest, string>
{
    public Task<string> Handle(CarParkToOutputRequest request, CancellationToken cancellationToken)
    {
        var output = CarParkOutputFormatter.Format(request.CarPark);
        return Task.FromResult(output);
    }
}
