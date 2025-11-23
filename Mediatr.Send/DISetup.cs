using System;
using System.Collections.Generic;
using MediatR;
using Parking.Domain;
using Parking.Mediatr.Send.BestMatchCarPark;
using Parking.Mediatr.Send.CarParkToOutput;
using Parking.Mediatr.Send.FetchDataFromUrl;
using Parking.Mediatr.Send.Information;
using Parking.Mediatr.Send.ParseCarParksFromData;

namespace Parking.Mediatr.Send
{
    internal sealed class DiSetup
    {
        public IMediator Mediator { get; set; }

        internal object CreateInstance(Type type)
        {
            if (type == typeof(IRequestHandler<InformationRequest, string>))
            {
                return new InformationRequestHandler(Mediator);
            }

            if (type == typeof(IRequestHandler<FetchDataFromUrlRequest, string>))
            {
                return new FetchDataFromUrlRequestHandler();
            }

            if (type == typeof(IRequestHandler<ParseCarParksFromDataRequest, IEnumerable<CarPark>>))
            {
                return new ParseCarParksFromDataRequestHandler();
            }

            if (type == typeof(IRequestHandler<BestMatchCarParkRequest, CarPark>))
            {
                return new BestMatchCarParkRequestHandler();
            }

            if (type == typeof(IRequestHandler<CarParkToOutputRequest, string>))
            {
                return new CarParkToOutputRequestHandler();
            }

            return null;
        }

        internal IEnumerable<object> CreateAllInstances(Type type)
        {
            yield break;
        }
    }
}
