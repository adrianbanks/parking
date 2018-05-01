using System;
using Paramore.Brighter;
using Parking.Domain;

namespace Parking.Brighter.CarParkToOutput
{
    internal sealed class CarParkToOutputCommand : IRequest
    {
        public Guid Id { get; set; }
        public CarPark BestMatch { get; }
        public string Output { get; set; }

        public CarParkToOutputCommand(CarPark bestMatch)
        {
            Id = Guid.NewGuid();
            BestMatch = bestMatch;
        }
    }
}
