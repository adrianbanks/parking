using System;
using Akka.Actor;

namespace Parking.Akka.Tell.SendOutput
{
    internal sealed class SendOutputActor : ReceiveActor
    {
        public SendOutputActor()
        {
            Receive<SendOutputMessage>(message =>
            {
                Console.WriteLine(message.Output);
                Context.System.Terminate();
            });
        }
    }
}
