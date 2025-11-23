using System;
using System.Collections.Generic;
using MediatR;
using Parking.Mediatr.Publish.BestMatchCarPark;
using Parking.Mediatr.Publish.CarParkToOutput;
using Parking.Mediatr.Publish.FetchDataFromUrl;
using Parking.Mediatr.Publish.Information;
using Parking.Mediatr.Publish.ParseCarParksFromData;
using Parking.Mediatr.Publish.SendOutput;

namespace Parking.Mediatr.Publish
{
    internal sealed class DiSetup
    {
        public IMediator Mediator { get; set; }

        internal object CreateInstance(Type type)
        {
            return null;
        }

        internal IEnumerable<object> CreateAllInstances(Type type)
        {
            if (type == typeof(INotificationHandler<InformationNotification>))
            {
                yield return new InformationNotificationHandler(Mediator);
            }

            if (type == typeof(INotificationHandler<FetchDataFromUrlNotification>))
            {
                yield return new FetchDataFromUrlNotificationHandler(Mediator);
            }

            if (type == typeof(INotificationHandler<ParseCarParksFromDataNotification>))
            {
                yield return new ParseCarParksFromDataNotificationHandler(Mediator);
            }

            if (type == typeof(INotificationHandler<BestMatchCarParkNotification>))
            {
                yield return new BestMatchCarParkNotificationHandler(Mediator);
            }

            if (type == typeof(INotificationHandler<CarParkToOutputNotification>))
            {
                yield return new CarParkToOutputNotificationHandler(Mediator);
            }

            if (type == typeof(INotificationHandler<SendOutputNotification>))
            {
                yield return new SendOutputNotificationHandler();
            }
        }
    }
}
