using System.Threading;
using System.Threading.Tasks;
using Parking.Domain;
using Shiny.Mediator;

namespace Parking.Shiny.Request.CarParkToOutput;

internal sealed class CarParkToOutputRequestHandler : IRequestHandler<CarParkToOutputRequest, string>
{
    public Task<string> Handle(CarParkToOutputRequest request, IMediatorContext context, CancellationToken cancellationToken)
    {
        var output = CarParkOutputFormatter.Format(request.CarPark);
        return Task.FromResult(output);
    }
}
