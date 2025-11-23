using Enexure.MicroBus;
using Parking.Domain;

namespace Parking.MicroBus.Query.CarParkToOutput;

internal sealed class CarParkToOutputQuery(CarPark bestMatch) : IQuery<CarParkToOutputQuery, string>
{
    public CarPark BestMatch { get; } = bestMatch;
}