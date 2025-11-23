namespace Parking.Akka.Ask.ParseCarParksFromData
{
    internal sealed class ParseCarParksFromDataMessage(string html)
    {
        public string Html { get; } = html;
    }
}
