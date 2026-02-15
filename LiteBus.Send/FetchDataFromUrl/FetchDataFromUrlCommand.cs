using LiteBus.Commands.Abstractions;

namespace Parking.LiteBus.Send.FetchDataFromUrl;

internal sealed class FetchDataFromUrlCommand(string url) : ICommand
{
    public string Url { get; } = url;
}
