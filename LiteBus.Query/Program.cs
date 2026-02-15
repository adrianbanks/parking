using System;
using System.Threading.Tasks;
using LiteBus.Extensions.Microsoft.DependencyInjection;
using LiteBus.Queries;
using LiteBus.Queries.Abstractions;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Parking.LiteBus.Query.Information;

namespace Parking.LiteBus.Query;

public static class Program
{
    public static async Task Main()
    {
        var host = new HostBuilder()
            .ConfigureServices((_, collection) =>
            {
                collection.AddLiteBus(liteBus =>
                {
                    liteBus.AddQueryModule(module =>
                    {
                        module.RegisterFromAssembly(typeof(Program).Assembly);
                    });
                });
            })
            .Build();

        var mediator = host.Services.GetRequiredService<IQueryMediator>();

        var output = await mediator.QueryAsync(new InformationQuery());
        Console.WriteLine(output);
    }
}
