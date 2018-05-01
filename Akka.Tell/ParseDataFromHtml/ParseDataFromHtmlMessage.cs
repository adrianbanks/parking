namespace Parking.Akka.Tell.ParseDataFromHtml
{
    internal sealed class ParseDataFromHtmlMessage
    {
        public string Html { get; }

        public ParseDataFromHtmlMessage(string html)
        {
            Html = html;
        }
    }
}
