namespace Parking.Akka.Ask.FetchDataFromUrl
{
    internal sealed class FetchDataFromUrlMessage
    {
        public string Url { get; }

        public FetchDataFromUrlMessage(string url)
        {
            Url = url;
        }
    }
}
