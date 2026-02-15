using LiteBus.Commands.Abstractions;
using Parking.Domain;

namespace Parking.LiteBus.Send.CarParkToOutput;

internal sealed class CarParkToOutputCommand(CarPark bestMatch) : ICommand
{
    public CarPark BestMatch { get; } = bestMatch;
}
