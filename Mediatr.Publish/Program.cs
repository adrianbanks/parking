using System;
using System.Threading.Tasks;
using MediatR;
using Parking.Mediatr.Publish.Information;

namespace Parking.Mediatr.Publish
{
    internal static class Program
    {
        internal static async Task Main()
        {
            var diSetup = new DiSetup();
            var mediator = new Mediator(diSetup.CreateInstance, diSetup.CreateAllInstances);
            diSetup.Mediator = mediator;

            await mediator.Publish(new InformationNotification());
            Console.ReadLine();
        }
    }
}
