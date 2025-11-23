using MediatR;

namespace Parking.Mediatr.Send.FetchDataFromUrl
{
    internal class FetchDataFromUrlRequest(string url) : IRequest<string>
    {
        public string Url { get; } = url;
    }
}
