using MediatR;

namespace Parking.Mediatr.Publish.ParseDataFromHtml
{
    internal sealed class ParseDataFromHtmlNotification : INotification
    {
        public string Html { get; }

        public ParseDataFromHtmlNotification(string html)
        {
            Html = html;
        }
    }
}
