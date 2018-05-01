using MediatR;

namespace Parking.Mediatr.Publish.FetchDataFromUrl
{
    internal class FetchDataFromUrlNotification : INotification
    {
        public string Url { get; }

        public FetchDataFromUrlNotification(string url)
        {
            Url = url;
        }
    }
}
