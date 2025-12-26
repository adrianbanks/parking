using System.Threading;
using System.Threading.Tasks;
using Mediator;
using Parking.Domain;
using Parking.Mediator.Send.BestMatchCarPark;
using Parking.Mediator.Send.CarParkToOutput;
using Parking.Mediator.Send.FetchDataFromUrl;
using Parking.Mediator.Send.ParseCarParksFromData;

namespace Parking.Mediator.Send.Information;

internal sealed class InformationRequestHandler(IMediator mediator) : IRequestHandler<InformationRequest, string>
{
    public async ValueTask<string> Handle(InformationRequest request, CancellationToken cancellationToken)
    {
        var data = await mediator.Send(new FetchDataFromUrlRequest(SourceData.Url), cancellationToken);
        var carParkData = await mediator.Send(new ParseCarParksFromDataRequest(data), cancellationToken);
        var bestCarPark = await mediator.Send(new BestMatchCarParkRequest(carParkData), cancellationToken);
        return await mediator.Send(new CarParkToOutputRequest(bestCarPark), cancellationToken);
    }
}
