namespace EventHorizon.Blazor.Server.Interop.Sample;

using System;
using System.Net.Http;
using System.Threading.Tasks;

using EventHorizon.Blazor.Server.Interop.Sample.Pages.DITesting.Model;

using MediatR;

using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using Microsoft.Extensions.DependencyInjection;

public class Program
{
    public static async Task Main(string[] args)
    {
        var builder = WebAssemblyHostBuilder.CreateDefault(args);
        builder.RootComponents.Add<App>("app");

        builder.Services
            .AddTransient(
                sp => new HttpClient
                {
                    BaseAddress = new Uri(builder.HostEnvironment.BaseAddress)
                }
            );
        builder.Services
            .AddSingleton<IDIRunHandler, DIRunHandlerImplementation>();
        builder.Services
            .AddMediatR(
                typeof(Program).Assembly
            );

        await builder.Build().RunAsync();
    }
}
