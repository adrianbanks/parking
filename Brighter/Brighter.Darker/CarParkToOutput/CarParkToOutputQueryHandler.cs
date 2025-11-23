using System.Threading;
using System.Threading.Tasks;
using Paramore.Darker;
using Parking.Domain;

namespace Parking.Brighter.Darker.CarParkToOutput;

internal sealed class CarParkToOutputQueryHandler : QueryHandlerAsync<CarParkToOutputQuery, string>
{
    public override Task<string> ExecuteAsync(CarParkToOutputQuery query, CancellationToken cancellationToken = default)
    {
        var output = CarParkOutputFormatter.Format(query.BestMatch);
        return Task.FromResult(output);
    }
}
