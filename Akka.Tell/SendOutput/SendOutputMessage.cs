namespace Parking.Akka.Tell.SendOutput
{
    internal sealed class SendOutputMessage(string output)
    {
        public string Output { get; } = output;
    }
}
