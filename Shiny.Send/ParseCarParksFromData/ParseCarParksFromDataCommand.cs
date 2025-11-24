using Shiny.Mediator;

namespace Parking.Shiny.Send.ParseCarParksFromData;

internal sealed class ParseCarParksFromDataCommand(string data) : ICommand
{
    public string Data { get; } = data;
}
