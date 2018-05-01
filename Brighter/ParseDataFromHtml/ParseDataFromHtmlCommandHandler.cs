using System.Threading;
using System.Threading.Tasks;
using Paramore.Brighter;
using Parking.Domain;

namespace Parking.Brighter.ParseDataFromHtml
{
    internal sealed class ParseDataFromHtmlCommandHandler : RequestHandlerAsync<ParseDataFromHtmlCommand>
    {
        public override async Task<ParseDataFromHtmlCommand> HandleAsync(ParseDataFromHtmlCommand command, CancellationToken cancellationToken = new CancellationToken())
        {
            var carParks = CarParkParser.ParseFromHtml(command.Html);
            command.CarParks = carParks;
            return await base.HandleAsync(command, cancellationToken);
        }
    }
}
