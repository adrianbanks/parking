using Enexure.MicroBus;

namespace Parking.MicroBus.Send.SendOutput
{
    internal sealed class SendOutputCommand : ICommand
    {
        public string Output { get; }

        public SendOutputCommand(string output)
        {
            Output = output;
        }
    }
}
