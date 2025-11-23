using System.Threading.Tasks;
using MediatR;
using Parking.Domain;
using Parking.Mediatr.Send.BestMatchCarPark;
using Parking.Mediatr.Send.CarParkToOutput;
using Parking.Mediatr.Send.FetchDataFromUrl;
using Parking.Mediatr.Send.ParseCarParksFromData;

namespace Parking.Mediatr.Send.Information;

internal sealed class InformationRequestHandler(IMediator mediator) : AsyncRequestHandler<InformationRequest, string>
{
    protected override async Task<string> HandleCore(InformationRequest request)
    {
        var data = await mediator.Send(new FetchDataFromUrlRequest(SourceData.Url));
        var carParkData = await mediator.Send(new ParseCarParksFromDataRequest(data));
        var bestCarPark = await mediator.Send(new BestMatchCarParkRequest(carParkData));
        return await mediator.Send(new CarParkToOutputRequest(bestCarPark));
    }
}
