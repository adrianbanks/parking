using Akka.Actor;
using Parking.Domain;

namespace Parking.Akka.Ask.CarParkToOutput
{
    internal sealed class CarParkToOutputActor : ReceiveActor
    {
        public CarParkToOutputActor()
        {
            Receive<CarParkToOutputMessage>(message =>
            {
                var output = CarParkOutputFormatter.Format(message.CarPark);
                Sender.Tell(output);
            });
        }
    }
}
