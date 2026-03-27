using System.Threading;
using System.Threading.Tasks;
using Mediator.Switch;
using Parking.Domain;
using Parking.SwitchMediator.ValueSend.BestMatchCarPark;
using Parking.SwitchMediator.ValueSend.CarParkToOutput;
using Parking.SwitchMediator.ValueSend.FetchDataFromUrl;
using Parking.SwitchMediator.ValueSend.ParseCarParksFromData;

namespace Parking.SwitchMediator.ValueSend.Information;

internal sealed class InformationRequestHandler(IValueSender sender) : IRequestHandler<InformationRequest, string>
{
    public async Task<string> Handle(InformationRequest request, CancellationToken cancellationToken)
    {
        var data = await sender.Send(new FetchDataFromUrlRequest(SourceData.Url), cancellationToken);
        var carParkData = await sender.Send(new ParseCarParksFromDataRequest(data), cancellationToken);
        var bestCarPark = await sender.Send(new BestMatchCarParkRequest(carParkData), cancellationToken);
        return await sender.Send(new CarParkToOutputRequest(bestCarPark), cancellationToken);
    }
}
