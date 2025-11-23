using Paramore.Darker;
using Parking.Domain;

namespace Parking.Brighter.Darker.CarParkToOutput;

internal sealed class CarParkToOutputQuery(CarPark bestMatch) : IQuery<string>
{
    public CarPark BestMatch { get; } = bestMatch;
}
