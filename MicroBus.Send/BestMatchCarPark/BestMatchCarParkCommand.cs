using System.Collections.Generic;
using Enexure.MicroBus;
using Parking.Domain;

namespace Parking.MicroBus.Send.BestMatchCarPark
{
    internal sealed class BestMatchCarParkCommand(IEnumerable<CarPark> carParks) : ICommand
    {
        public IEnumerable<CarPark> CarParks { get; } = carParks;
    }
}
