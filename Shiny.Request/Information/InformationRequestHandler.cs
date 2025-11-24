using System.Threading;
using System.Threading.Tasks;
using Parking.Domain;
using Parking.Shiny.Request.BestMatchCarPark;
using Parking.Shiny.Request.CarParkToOutput;
using Parking.Shiny.Request.FetchDataFromUrl;
using Parking.Shiny.Request.ParseCarParksFromData;
using Shiny.Mediator;

namespace Parking.Shiny.Request.Information;

internal sealed class InformationRequestHandler(IMediator mediator) : IRequestHandler<InformationRequest, string>
{
    public async Task<string> Handle(InformationRequest request, IMediatorContext context, CancellationToken cancellationToken)
    {
        var data = await mediator.Request(new FetchDataFromUrlRequest(SourceData.Url), cancellationToken);
        var carParkData = await mediator.Request(new ParseCarParksFromDataRequest(data.Result), cancellationToken);
        var bestCarPark = await mediator.Request(new BestMatchCarParkRequest(carParkData.Result), cancellationToken);
        var output = await mediator.Request(new CarParkToOutputRequest(bestCarPark.Result), cancellationToken);
        return output.Result;
    }
}
