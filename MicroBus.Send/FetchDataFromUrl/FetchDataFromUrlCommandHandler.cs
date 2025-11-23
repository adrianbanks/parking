using System.Threading.Tasks;
using Enexure.MicroBus;
using Parking.Domain;
using Parking.MicroBus.Send.ParseCarParksFromData;

namespace Parking.MicroBus.Send.FetchDataFromUrl
{
    internal sealed class FetchDataFromUrlCommandHandler(IMicroBus bus) : ICommandHandler<FetchDataFromUrlCommand>
    {
        public async Task Handle(FetchDataFromUrlCommand command)
        {
            var data = await DataFetcher.FetchData(command.Url);
            await bus.SendAsync(new ParseCarParksFromDataCommand(data));
        }
    }
}
