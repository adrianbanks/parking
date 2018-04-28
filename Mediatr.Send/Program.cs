using System;
using System.Threading.Tasks;
using MediatR;
using Parking.Mediatr.Send.Information;

namespace Parking.Mediatr.Send
{
    internal static class Program
    {
        internal static async Task Main()
        {
            var diSetup = new DiSetup();
            var mediator = new Mediator(diSetup.CreateInstance, diSetup.CreateAllInstances);
            diSetup.Mediator = mediator;

            var output = await mediator.Send(new InformationRequest());
            Console.WriteLine(output);
        }
    }
}
