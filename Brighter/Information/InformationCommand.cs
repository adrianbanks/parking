using System;
using Paramore.Brighter;

namespace Parking.Brighter.Information;

internal sealed class InformationCommand() : Command(Guid.NewGuid())
{
    public string Url { get; set; }
}
