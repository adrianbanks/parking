using System.Threading.Tasks;
using Enexure.MicroBus;
using Parking.Domain;

namespace Parking.MicroBus.Query.CarParkToOutput;

internal sealed class CarParkToOutputQueryHandler : IQueryHandler<CarParkToOutputQuery, string>
{
    public async Task<string> Handle(CarParkToOutputQuery query)
    {
        var output = CarParkOutputFormatter.Format(query.BestMatch);
        return await Task.FromResult(output);
    }
}