using Mediator;

namespace Parking.Mediator.Send.FetchDataFromUrl;

internal class FetchDataFromUrlRequest(string url) : IRequest<string>
{
    public string Url { get; } = url;
}
