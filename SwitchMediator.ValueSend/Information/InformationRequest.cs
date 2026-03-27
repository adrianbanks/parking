using Mediator.Switch;

namespace Parking.SwitchMediator.ValueSend.Information;

[RequestHandler(typeof(InformationRequestHandler))]
internal sealed class InformationRequest : IRequest<string>;
