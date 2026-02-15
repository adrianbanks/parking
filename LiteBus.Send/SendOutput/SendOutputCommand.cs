using LiteBus.Commands.Abstractions;

namespace Parking.LiteBus.Send.SendOutput;

internal sealed class SendOutputCommand(string output) : ICommand
{
    public string Output { get; } = output;
}
