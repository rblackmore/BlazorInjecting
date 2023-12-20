using BlazorWASMInjection.Client.Services;

using Blazored.LocalStorage;

using Microsoft.AspNetCore.Components.WebAssembly.Hosting;

var builder = WebAssemblyHostBuilder.CreateDefault(args);

// Register Sample Service in Client Project.
builder.Services.AddSingleton<ISampleDataService, SampleDataService>();
builder.Services.AddBlazoredLocalStorage();

await builder.Build().RunAsync();
