using MediatR;

namespace Parking.Mediatr.Publish.ParseCarParksFromData
{
    internal sealed class ParseCarParksFromDataNotification(string html) : INotification
    {
        public string Html { get; } = html;
    }
}
