using Enexure.MicroBus;

namespace Parking.MicroBus.Send.ParseCarParksFromData
{
    internal sealed class ParseCarParksFromDataCommand(string html) : ICommand
    {
        public string Html { get; } = html;
    }
}
