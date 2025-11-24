using System.Threading;
using System.Threading.Tasks;
using Parking.Domain;
using Parking.Shiny.Send.FetchDataFromUrl;
using Shiny.Mediator;

namespace Parking.Shiny.Send.Information;

internal sealed class InformationCommandHandler(IMediator mediator) : ICommandHandler<InformationCommand>
{
    public async Task Handle(InformationCommand command, IMediatorContext context, CancellationToken cancellationToken)
    {
        await mediator.Send(new FetchDataFromUrlCommand(SourceData.Url), cancellationToken);
    }
}
