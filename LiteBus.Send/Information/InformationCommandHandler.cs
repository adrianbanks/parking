using System.Threading;
using System.Threading.Tasks;
using LiteBus.Commands.Abstractions;
using Parking.Domain;
using Parking.LiteBus.Send.FetchDataFromUrl;

namespace Parking.LiteBus.Send.Information;

internal sealed class InformationCommandHandler(ICommandMediator mediator) : ICommandHandler<InformationCommand>
{
    public async Task HandleAsync(InformationCommand message, CancellationToken cancellationToken)
    {
        await mediator.SendAsync(new FetchDataFromUrlCommand(SourceData.Url), cancellationToken);
    }
}
