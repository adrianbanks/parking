using MediatR;

namespace Parking.Mediatr.Publish.FetchDataFromUrl;

internal class FetchDataFromUrlNotification(string url) : INotification
{
    public string Url { get; } = url;
}