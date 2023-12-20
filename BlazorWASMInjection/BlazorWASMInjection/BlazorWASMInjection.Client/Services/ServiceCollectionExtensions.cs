namespace BlazorWASMInjection.Client.Services;

public static class ServiceCollectionExtensions
{
  /// <summary>
  /// Register the Sample Service here.
  /// This extension method can be called form both the host and client projects.
  /// </summary>
  public static IServiceCollection AddCommonServices(this IServiceCollection services)
  {
    return services.AddSingleton<ISampleDataService, SampleDataService>();
  }
}
