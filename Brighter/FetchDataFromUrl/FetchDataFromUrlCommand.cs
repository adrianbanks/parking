using System;
using Paramore.Brighter;

namespace Parking.Brighter.FetchDataFromUrl;

internal sealed class FetchDataFromUrlCommand(string url) : Command(Guid.NewGuid())
{
    public string Url { get; } = url;
    public string Data { get; set; }
}
