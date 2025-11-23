namespace Parking.Akka.Ask.ParseCarParksFromData
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
