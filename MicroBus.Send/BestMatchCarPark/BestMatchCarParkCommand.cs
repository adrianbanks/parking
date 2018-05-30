using System.Collections.Generic;
using Enexure.MicroBus;
using Parking.Domain;

namespace Parking.MicroBus.Send.BestMatchCarPark
{
    internal sealed class BestMatchCarParkCommand : ICommand
    {
        public IEnumerable<CarPark> CarParks { get; }

        public BestMatchCarParkCommand(IEnumerable<CarPark> carParks)
        {
            CarParks = carParks;
        }
    }
}
