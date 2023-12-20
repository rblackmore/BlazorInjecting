namespace BlazorWASMInjection.Client.Services;

public interface ISampleDataService
{
  string GetData();
}
public class SampleDataService : ISampleDataService
{
  public string GetData()
  {
    return "Data from Data Service in Client Project";
  }
}
