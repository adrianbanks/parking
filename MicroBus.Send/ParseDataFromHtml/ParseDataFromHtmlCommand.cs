using Enexure.MicroBus;

namespace Parking.MicroBus.Send.ParseDataFromHtml
{
    internal sealed class ParseDataFromHtmlCommand : ICommand
    {
        public string Html { get; }

        public ParseDataFromHtmlCommand(string html)
        {
            Html = html;
        }
    }
}
