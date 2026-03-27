using Mediator.Switch;

namespace Parking.SwitchMediator.Send.FetchDataFromUrl;

[RequestHandler(typeof(FetchDataFromUrlRequestHandler))]
internal class FetchDataFromUrlRequest(string url) : IRequest<string>
{
    public string Url { get; } = url;
}
