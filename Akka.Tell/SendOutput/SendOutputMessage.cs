namespace Parking.Akka.Tell.SendOutput
{
    internal sealed class SendOutputMessage
    {
        public string Output { get; }

        public SendOutputMessage(string output)
        {
            Output = output;
        }
    }
}
