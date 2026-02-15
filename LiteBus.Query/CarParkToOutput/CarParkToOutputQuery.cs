using LiteBus.Queries.Abstractions;
using Parking.Domain;

namespace Parking.LiteBus.Query.CarParkToOutput;

internal sealed class CarParkToOutputQuery(CarPark bestMatch) : IQuery<string>
{
    public CarPark BestMatch { get; } = bestMatch;
}
