using System.Threading;
using System.Threading.Tasks;
using Paramore.Darker;
using Parking.Domain;

namespace Parking.Brighter.Darker.Information;

internal sealed class InformationQueryHandler : QueryHandlerAsync<InformationQuery, string>
{
    public override Task<string> ExecuteAsync(InformationQuery query, CancellationToken cancellationToken = default)
    {
        return Task.FromResult(SourceData.Url);
    }
}
