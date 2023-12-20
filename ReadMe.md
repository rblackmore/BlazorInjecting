# BlazorInjection Sample
---
Testing Dependency Injection with a Blazor Web Application in .NET 8.

## Problem
---
Injecting dependencies into components fails if the dependency is not registered in both the Host and Client projects.

## Attempted Solutions
---
### 01 Dual Registration
This works, however feels clunky to me. By creating an extension method for IServiceCollection, I register my services, and call this extension method from both the Host and Client projects Program.cs files during startup.

```csharp 
public static class ServiceCollectionExtensions
{
  public static IServiceCollection AddCommonServices(this IServiceCollection services)
  {
    return services.AddSingleton<ISampleDataService, SampleDataService>();
  }
}
```
Client Program.cs
```csharp
...
var builder = WebAssemblyHostBuilder.CreateDefault(args);

builder.Services.AddCommonServices();

await builder.Build().RunAsync();
```
Host Program.cs
```csharp
...
builder.Services.AddRazorComponents()
    .AddInteractiveWebAssemblyComponents();

builder.Services.AddCommonServices();

var app = builder.Build();
...
```
## References
---
1. [GitHub Issue dotnet/aspnetcore#51432](https://github.com/dotnet/aspnetcore/issues/51432)
