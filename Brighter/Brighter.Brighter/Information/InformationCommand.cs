using Paramore.Brighter;

namespace Parking.Brighter.Brighter.Information;

internal sealed class InformationCommand() : Command(Id.Random())
{
    public string Url { get; set; }
}
