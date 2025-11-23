using Paramore.Brighter;

namespace Parking.Brighter.Information;

internal sealed class InformationCommand() : Command(Id.Random())
{
    public string Url { get; set; }
}
