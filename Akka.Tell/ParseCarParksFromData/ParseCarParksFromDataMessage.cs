namespace Parking.Akka.Tell.ParseCarParksFromData
{
    internal sealed class ParseCarParksFromDataMessage
    {
        public string Html { get; }

        public ParseCarParksFromDataMessage(string html)
        {
            Html = html;
        }
    }
}
