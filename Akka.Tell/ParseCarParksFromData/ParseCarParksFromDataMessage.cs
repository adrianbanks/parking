namespace Parking.Akka.Tell.ParseCarParksFromData
{
    internal sealed class ParseCarParksFromDataMessage(string html)
    {
        public string Html { get; } = html;
    }
}
