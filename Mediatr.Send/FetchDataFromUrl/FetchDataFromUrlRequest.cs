using MediatR;

namespace Parking.Mediatr.Send.FetchDataFromUrl
{
    internal class FetchDataFromUrlRequest : IRequest<string>
    {
        public string Url { get; }

        public FetchDataFromUrlRequest(string url)
        {
            Url = url;
        }
    }
}
