using MediatR;

namespace Parking.Mediatr.Publish.ParseCarParksFromData
{
    internal sealed class ParseCarParksFromDataNotification(string data) : INotification
    {
        public string Data { get; } = data;
    }
}
