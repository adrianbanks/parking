using MediatR;

namespace Parking.Mediatr.Publish.ParseCarParksFromData
{
    internal sealed class ParseCarParksFromDataNotification : INotification
    {
        public string Html { get; }

        public ParseCarParksFromDataNotification(string html)
        {
            Html = html;
        }
    }
}
