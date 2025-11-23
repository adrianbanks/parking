namespace Parking.Akka.Tell.FetchDataFromUrl;

internal sealed class FetchDataFromUrlMessage(string url)
{
    public string Url { get; } = url;
}