using BlazorWASMInjection.Client.Services;

using Microsoft.AspNetCore.Components.WebAssembly.Hosting;

var builder = WebAssemblyHostBuilder.CreateDefault(args);

// Add Common Sample Services.
// This feels clunky, I don't like it, but maybe it's the right way to go?
builder.Services.AddCommonServices();

await builder.Build().RunAsync();
