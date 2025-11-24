using Shiny.Mediator;

namespace Parking.Shiny.Send.FetchDataFromUrl;

internal class FetchDataFromUrlCommand(string url) : ICommand
{
    public string Url { get; } = url;
}
