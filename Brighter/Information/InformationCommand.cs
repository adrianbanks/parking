using System;
using Paramore.Brighter;

namespace Parking.Brighter.Information;

internal sealed class InformationCommand : IRequest
{
    public Guid Id { get; set; } = Guid.NewGuid();
    public string Url { get; set; }
}
