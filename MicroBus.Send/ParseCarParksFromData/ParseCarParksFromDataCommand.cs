using Enexure.MicroBus;

namespace Parking.MicroBus.Send.ParseCarParksFromData
{
    internal sealed class ParseCarParksFromDataCommand : ICommand
    {
        public string Html { get; }

        public ParseCarParksFromDataCommand(string html)
        {
            Html = html;
        }
    }
}
