using BlazorWASMGlobalInteractivity.Client.Services;

using Microsoft.AspNetCore.Components.WebAssembly.Hosting;

var builder = WebAssemblyHostBuilder.CreateDefault(args);

builder.Services.AddSingleton<ISampleDataService, AnotherAwesomeDataService>();

await builder.Build().RunAsync();
