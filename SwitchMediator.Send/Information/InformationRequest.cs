using Mediator.Switch;

namespace Parking.SwitchMediator.Send.Information;

[RequestHandler(typeof(InformationRequestHandler))]
internal sealed class InformationRequest : IRequest<string>;
