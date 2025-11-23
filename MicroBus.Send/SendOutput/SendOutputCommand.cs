using Enexure.MicroBus;

namespace Parking.MicroBus.Send.SendOutput
{
    internal sealed class SendOutputCommand(string output) : ICommand
    {
        public string Output { get; } = output;
    }
}
