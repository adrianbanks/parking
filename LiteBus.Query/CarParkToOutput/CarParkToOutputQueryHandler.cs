using System.Threading;
using System.Threading.Tasks;
using LiteBus.Queries.Abstractions;
using Parking.Domain;

namespace Parking.LiteBus.Query.CarParkToOutput;

internal sealed class CarParkToOutputQueryHandler : IQueryHandler<CarParkToOutputQuery, string>
{
    public async Task<string> HandleAsync(CarParkToOutputQuery message, CancellationToken cancellationToken)
    {
        var output = CarParkOutputFormatter.Format(message.BestMatch);
        return await Task.FromResult(output);
    }
}
