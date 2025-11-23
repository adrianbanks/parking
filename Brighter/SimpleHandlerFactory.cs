using System;
using Paramore.Brighter;
using Parking.Brighter.BestMatchCarPark;
using Parking.Brighter.CarParkToOutput;
using Parking.Brighter.FetchDataFromUrl;
using Parking.Brighter.Information;
using Parking.Brighter.ParseCarParksFromData;

namespace Parking.Brighter
{
    internal sealed class SimpleHandlerFactory : IAmAHandlerFactoryAsync
    {
        public IHandleRequestsAsync Create(Type handlerType)
        {
            if (handlerType == typeof(InformationCommandHandler))
            {
                return new InformationCommandHandler();
            }

            if (handlerType == typeof(FetchDataFromUrlRequestHandler))
            {
                return new FetchDataFromUrlRequestHandler();
            }

            if (handlerType == typeof(ParseCarParksFromDataCommandHandler))
            {
                return new ParseCarParksFromDataCommandHandler();
            }

            if (handlerType == typeof(BestMatchCarParkCommandHandler))
            {
                return new BestMatchCarParkCommandHandler();
            }

            if (handlerType == typeof(CarParkToOutputCommandHandler))
            {
                return new CarParkToOutputCommandHandler();
            }

            return null;
        }

        public void Release(IHandleRequestsAsync handler)
        { }
    }
}
