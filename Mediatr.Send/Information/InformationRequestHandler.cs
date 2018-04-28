using System.Threading.Tasks;
using MediatR;
using Parking.Domain;
using Parking.Mediatr.Send.BestMatchCarPark;
using Parking.Mediatr.Send.CarParkToOutput;
using Parking.Mediatr.Send.FetchDataFromUrl;
using Parking.Mediatr.Send.ParseDataFromHtml;

namespace Parking.Mediatr.Send.Information
{
    internal sealed class InformationRequestHandler : AsyncRequestHandler<InformationRequest, string>
    {
        private readonly IMediator mediator;

        public InformationRequestHandler(IMediator mediator)
        {
            this.mediator = mediator;
        }

        protected override async Task<string> HandleCore(InformationRequest request)
        {
            var html = await mediator.Send(new FetchDataFromUrlRequest(SourceData.Url));
            var carParkData = await mediator.Send(new ParseDataFromHtmlRequest(html));
            var bestCarPark = await mediator.Send(new BestMatchCarParkRequest(carParkData));
            return await mediator.Send(new CarParkToOutputRequest(bestCarPark));
        }
    }
}
