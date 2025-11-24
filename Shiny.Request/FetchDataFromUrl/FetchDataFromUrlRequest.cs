using Shiny.Mediator;

namespace Parking.Shiny.Request.FetchDataFromUrl;

internal class FetchDataFromUrlRequest(string url) : IRequest<string>
{
    public string Url { get; } = url;
}
