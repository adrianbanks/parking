using LiteBus.Commands.Abstractions;

namespace Parking.LiteBus.Send.ParseCarParksFromData;

internal sealed class ParseCarParksFromDataCommand(string data) : ICommand
{
    public string Data { get; } = data;
}
