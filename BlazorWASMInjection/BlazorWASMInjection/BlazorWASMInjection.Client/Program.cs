using BlazorWASMInjection.Client.Services;

using Microsoft.AspNetCore.Components.WebAssembly.Hosting;

var builder = WebAssemblyHostBuilder.CreateDefault(args);

// Register Sample Service in Client Project.
builder.Services.AddSingleton<ISampleDataService, SampleDataService>();

await builder.Build().RunAsync();
