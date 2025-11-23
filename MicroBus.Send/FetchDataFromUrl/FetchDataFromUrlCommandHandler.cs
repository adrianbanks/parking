using System.Threading.Tasks;
using Enexure.MicroBus;
using Parking.Domain;
using Parking.MicroBus.Send.ParseCarParksFromData;

namespace Parking.MicroBus.Send.FetchDataFromUrl
{
    internal sealed class FetchDataFromUrlCommandHandler : ICommandHandler<FetchDataFromUrlCommand>
    {
        private readonly IMicroBus bus;

        public FetchDataFromUrlCommandHandler(IMicroBus bus) => this.bus = bus;

        public async Task Handle(FetchDataFromUrlCommand command)
        {
            var html = await DataFetcher.FetchData(command.Url);
            await bus.SendAsync(new ParseCarParksFromDataCommand(html));
        }
    }
}
