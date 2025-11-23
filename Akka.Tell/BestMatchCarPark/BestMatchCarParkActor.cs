using Akka.Actor;
using Parking.Akka.Tell.CarParkToOutput;
using Parking.Domain;

namespace Parking.Akka.Tell.BestMatchCarPark;

internal sealed class BestMatchCarParkActor : ReceiveActor
{
    public BestMatchCarParkActor()
    {
        var outputActor = Context.ActorOf<CarParkToOutputActor>();

        Receive<BestMatchCarParkMessage>(message =>
        {
            var bestCarPark = BestMatchCalculator.CalculateBestMatch(message.CarParks);
            outputActor.Tell(new CarParkToOutputMessage(bestCarPark));
        });
    }
}