using Enexure.MicroBus;

namespace Parking.MicroBus.Send.ParseCarParksFromData;

internal sealed class ParseCarParksFromDataCommand(string data) : ICommand
{
    public string Data { get; } = data;
}
