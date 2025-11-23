using System;
using Paramore.Brighter;
using Parking.Domain;

namespace Parking.Brighter.CarParkToOutput
{
    internal sealed class CarParkToOutputCommand(CarPark bestMatch) : IRequest
    {
        public Guid Id { get; set; } = Guid.NewGuid();
        public CarPark BestMatch { get; } = bestMatch;
        public string Output { get; set; }
    }
}
