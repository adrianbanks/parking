using System;
using Paramore.Brighter;

namespace Parking.Brighter.FetchDataFromUrl
{
    internal sealed class FetchDataFromUrlCommand : IRequest
    {
        public Guid Id { get; set; }
        public string Url { get; }
        public string Html { get; set; }

        public FetchDataFromUrlCommand(string url)
        {
            Id = Guid.NewGuid();
            Url = url;
        }
    }
}
