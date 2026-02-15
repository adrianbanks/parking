using LiteBus.Events.Abstractions;
using Parking.Domain;

namespace Parking.LiteBus.Publish.CarParkToOutput;

internal sealed class CarParkToOutputEvent(CarPark bestMatch) : IEvent
{
    public CarPark BestMatch { get; } = bestMatch;
}
