﻿using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Autofac;
using Enexure.MicroBus;
using Enexure.MicroBus.Autofac;
using Parking.Domain;
using Parking.MicroBus.Query.BestMatchCarPark;
using Parking.MicroBus.Query.CarParkToOutput;
using Parking.MicroBus.Query.FetchDataFromUrl;
using Parking.MicroBus.Query.Information;
using Parking.MicroBus.Query.ParseDataFromHtml;

namespace Parking.MicroBus.Query
{
    internal static class Program
    {
        internal static async Task Main()
        {
            var busBuilder = new BusBuilder()
                .RegisterQueryHandler<InformationQuery, string, InformationQueryHandler>()
                .RegisterQueryHandler<FetchDataFromUrlQuery, string, FetchDataFromUrlQueryHandler>()
                .RegisterQueryHandler<ParseDataFromHtmlQuery, IEnumerable<CarPark>, ParseDataFromHtmlQueryHandler>()
                .RegisterQueryHandler<BestMatchCarParkQuery, CarPark, BestMatchCarParkQueryHandler>()
                .RegisterQueryHandler<CarParkToOutputQuery, string, CarParkToOutputQueryHandler>();

            var container = new ContainerBuilder().RegisterMicroBus(busBuilder).Build();
            var microBus = container.Resolve<IMicroBus>();

            var output = await microBus.QueryAsync(new InformationQuery());
            Console.WriteLine(output);
        }
    }
}
