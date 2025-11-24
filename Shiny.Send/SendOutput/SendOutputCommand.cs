using Shiny.Mediator;

namespace Parking.Shiny.Send.SendOutput;

internal sealed class SendOutputCommand(string output) : ICommand
{
    public string Output { get; } = output;
}
