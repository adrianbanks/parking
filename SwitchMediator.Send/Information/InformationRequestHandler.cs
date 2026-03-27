using System.Threading;
using System.Threading.Tasks;
using Mediator.Switch;
using Parking.Domain;
using Parking.SwitchMediator.Send.BestMatchCarPark;
using Parking.SwitchMediator.Send.CarParkToOutput;
using Parking.SwitchMediator.Send.FetchDataFromUrl;
using Parking.SwitchMediator.Send.ParseCarParksFromData;

namespace Parking.SwitchMediator.Send.Information;

internal sealed class InformationRequestHandler(ISender sender) : IRequestHandler<InformationRequest, string>
{
    public async Task<string> Handle(InformationRequest request, CancellationToken cancellationToken)
    {
        var data = await sender.Send(new FetchDataFromUrlRequest(SourceData.Url), cancellationToken);
        var carParkData = await sender.Send(new ParseCarParksFromDataRequest(data), cancellationToken);
        var bestCarPark = await sender.Send(new BestMatchCarParkRequest(carParkData), cancellationToken);
        return await sender.Send(new CarParkToOutputRequest(bestCarPark), cancellationToken);
    }
}
