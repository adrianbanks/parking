using Enexure.MicroBus;

namespace Parking.MicroBus.Send.FetchDataFromUrl;

internal sealed class FetchDataFromUrlCommand(string url) : ICommand
{
    public string Url { get; } = url;
}