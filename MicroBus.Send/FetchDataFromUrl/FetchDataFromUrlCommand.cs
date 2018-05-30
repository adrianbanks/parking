using Enexure.MicroBus;

namespace Parking.MicroBus.Send.FetchDataFromUrl
{
    internal sealed class FetchDataFromUrlCommand : ICommand
    {
        public string Url { get; }

        public FetchDataFromUrlCommand(string url)
        {
            Url = url;
        }
    }
}
