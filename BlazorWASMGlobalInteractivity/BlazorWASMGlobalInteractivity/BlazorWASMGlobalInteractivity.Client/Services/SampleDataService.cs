namespace BlazorWASMGlobalInteractivity.Client.Services;




public interface ISampleDataService
{
  string GetSampleData();
}




public class SampleDataService : ISampleDataService
{
  public string GetSampleData()
  {
    return "Sample Data from Client Side Sample Service";
  }
}

public class AnotherAwesomeDataService : ISampleDataService
{
  public string GetSampleData()
  {
    return DateTime.Now.ToString();
  }
}


