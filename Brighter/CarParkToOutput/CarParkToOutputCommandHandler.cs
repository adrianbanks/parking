using System.Threading;
using System.Threading.Tasks;
using Paramore.Brighter;
using Parking.Domain;

namespace Parking.Brighter.CarParkToOutput;

internal sealed class CarParkToOutputCommandHandler : RequestHandlerAsync<CarParkToOutputCommand>
{
    public override async Task<CarParkToOutputCommand> HandleAsync(CarParkToOutputCommand command, CancellationToken cancellationToken = default)
    {
        var output = CarParkOutputFormatter.Format(command.BestMatch);
        command.Output = output;
        return await base.HandleAsync(command, cancellationToken);
    }
}
