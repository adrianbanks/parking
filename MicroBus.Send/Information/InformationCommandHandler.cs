using System.Threading.Tasks;
using Enexure.MicroBus;
using Parking.Domain;
using Parking.MicroBus.Send.FetchDataFromUrl;

namespace Parking.MicroBus.Send.Information
{
    internal sealed class InformationCommandHandler : ICommandHandler<InformationCommand>
    {
        private readonly IMicroBus bus;

        public InformationCommandHandler(IMicroBus bus) => this.bus = bus;

        public async Task Handle(InformationCommand command)
        {
            await bus.SendAsync(new FetchDataFromUrlCommand(SourceData.Url));
        }
    }
}
