using Akka.Actor;
using Parking.Akka.Tell.SendOutput;
using Parking.Domain;

namespace Parking.Akka.Tell.CarParkToOutput
{
    internal sealed class CarParkToOutputActor : ReceiveActor
    {
        public CarParkToOutputActor()
        {
            var sendOutputActor = Context.ActorOf<SendOutputActor>();

            Receive<CarParkToOutputMessage>(message =>
            {
                var output = CarParkOutputFormatter.Format(message.CarPark);
                sendOutputActor.Tell(new SendOutputMessage(output));
            });
        }
    }
}
