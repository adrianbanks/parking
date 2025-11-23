using System;
using System.Collections.Generic;
using Paramore.Brighter;
using Parking.Domain;

namespace Parking.Brighter.ParseCarParksFromData;

internal sealed class ParseCarParksFromDataCommand(string data) : Command(Guid.NewGuid())
{
    public string Data { get; } = data;
    public IEnumerable<CarPark> CarParks { get; set; }
}
