using Akka.Actor;
using Parking.Domain;

namespace Parking.Akka.Ask.BestMatchCarPark
{
    internal sealed class BestMatchCarParkActor : ReceiveActor
    {
        public BestMatchCarParkActor()
        {
            Receive<BestMatchCarParkMessage>(message =>
            {
                var bestCarPark = BestMatchCalculator.CalculateBestMatch(message.CarParks);
                Sender.Tell(bestCarPark);
            });
        }
    }
}
