namespace Parking.Akka.Ask.FetchDataFromUrl;

internal sealed class FetchDataFromUrlMessage(string url)
{
    public string Url { get; } = url;
}
