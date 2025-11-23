using System.Threading;
using System.Threading.Tasks;
using Paramore.Brighter;
using Parking.Domain;

namespace Parking.Brighter.ParseCarParksFromData
{
    internal sealed class ParseCarParksFromDataCommandHandler : RequestHandlerAsync<ParseCarParksFromDataCommand>
    {
        public override async Task<ParseCarParksFromDataCommand> HandleAsync(ParseCarParksFromDataCommand command, CancellationToken cancellationToken = new CancellationToken())
        {
            var carParks = CarParkParser.Parse(command.Data);
            command.CarParks = carParks;
            return await base.HandleAsync(command, cancellationToken);
        }
    }
}
