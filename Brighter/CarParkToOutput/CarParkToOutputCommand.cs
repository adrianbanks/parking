using Paramore.Brighter;
using Parking.Domain;

namespace Parking.Brighter.CarParkToOutput;

internal sealed class CarParkToOutputCommand(CarPark bestMatch) : Command(Id.Random())
{
    public CarPark BestMatch { get; } = bestMatch;
    public string Output { get; set; }
}
