using System.Threading;
using System.Threading.Tasks;
using Paramore.Brighter;
using Parking.Domain;

namespace Parking.Brighter.Information;

internal sealed class InformationCommandHandler : RequestHandlerAsync<InformationCommand>
{
    public override async Task<InformationCommand> HandleAsync(InformationCommand command, CancellationToken cancellationToken = new CancellationToken())
    {
        command.Url = SourceData.Url;
        return await base.HandleAsync(command, cancellationToken);
    }
}