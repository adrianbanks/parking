using System.Threading;
using System.Threading.Tasks;
using MediatR;
using Parking.Domain;
using Parking.Mediatr.Send.BestMatchCarPark;
using Parking.Mediatr.Send.CarParkToOutput;
using Parking.Mediatr.Send.FetchDataFromUrl;
using Parking.Mediatr.Send.ParseCarParksFromData;

namespace Parking.Mediatr.Send.Information;

internal sealed class InformationRequestHandler(IMediator mediator) : IRequestHandler<InformationRequest, string>
{
    public async Task<string> Handle(InformationRequest request, CancellationToken cancellationToken)
    {
        var data = await mediator.Send(new FetchDataFromUrlRequest(SourceData.Url), cancellationToken);
        var carParkData = await mediator.Send(new ParseCarParksFromDataRequest(data), cancellationToken);
        var bestCarPark = await mediator.Send(new BestMatchCarParkRequest(carParkData), cancellationToken);
        return await mediator.Send(new CarParkToOutputRequest(bestCarPark), cancellationToken);
    }
}
