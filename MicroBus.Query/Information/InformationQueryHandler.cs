using System.Threading.Tasks;
using Enexure.MicroBus;
using Parking.Domain;
using Parking.MicroBus.Query.BestMatchCarPark;
using Parking.MicroBus.Query.CarParkToOutput;
using Parking.MicroBus.Query.FetchDataFromUrl;
using Parking.MicroBus.Query.ParseCarParksFromData;

namespace Parking.MicroBus.Query.Information
{
    internal sealed class InformationQueryHandler : IQueryHandler<InformationQuery, string>
    {
        private readonly IMicroBus bus;

        public InformationQueryHandler(IMicroBus bus) => this.bus = bus;

        public async Task<string> Handle(InformationQuery query)
        {
            var html = await bus.QueryAsync(new FetchDataFromUrlQuery(SourceData.Url));
            var carParkData = await bus.QueryAsync(new ParseCarParksFromDataQuery(html));
            var bestCarPark = await bus.QueryAsync(new BestMatchCarParkQuery(carParkData));
            return await bus.QueryAsync(new CarParkToOutputQuery(bestCarPark));
        }
    }
}
