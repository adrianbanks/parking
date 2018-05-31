using Enexure.MicroBus;
using Parking.Domain;

namespace Parking.MicroBus.Query.CarParkToOutput
{
    internal sealed class CarParkToOutputQuery : IQuery<CarParkToOutputQuery, string>
    {
        public CarPark BestMatch { get; }

        public CarParkToOutputQuery(CarPark bestMatch)
        {
            BestMatch = bestMatch;
        }
    }
}
