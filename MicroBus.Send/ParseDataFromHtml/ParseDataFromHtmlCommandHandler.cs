using System.Threading.Tasks;
using Enexure.MicroBus;
using Parking.Domain;
using Parking.MicroBus.Send.BestMatchCarPark;

namespace Parking.MicroBus.Send.ParseDataFromHtml
{
    internal sealed class ParseDataFromHtmlCommandHandler : ICommandHandler<ParseDataFromHtmlCommand>
    {
        private readonly IMicroBus bus;

        public ParseDataFromHtmlCommandHandler(IMicroBus bus) => this.bus = bus;

        public async Task Handle(ParseDataFromHtmlCommand command)
        {
            var carParks = CarParkParser.ParseFromHtml(command.Html);
            await bus.SendAsync(new BestMatchCarParkCommand(carParks));
        }
    }
}
