using System;
using System.Net.Http;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using Microsoft.Extensions.DependencyInjection;
using MudBlazor.Services;
using Syncfusion.Blazor;

namespace CampaignsWithoutNumber.Client
{
  public class Program
  {
    public static async Task Main(string[] args)
    {
      var builder = WebAssemblyHostBuilder.CreateDefault(args);
      builder.RootComponents.Add<App>("app");

      builder.Services.AddTransient(_ => new HttpClient { BaseAddress = new Uri(builder.HostEnvironment.BaseAddress) });
      builder.Services.AddMudServices();
      builder.Services.AddSyncfusionBlazor();
      builder.Services.AddSingleton(typeof(ISyncfusionStringLocalizer), typeof(SampleLocalizer));
      
      Syncfusion.Licensing.SyncfusionLicenseProvider.RegisterLicense("NzIyNzM2QDMyMzAyZTMyMmUzMFdZQXlXTlFyR1hPTWdYNCttYVNRK3IzQ0FtM0ZPUWkrUVRnVkNpSWE2LzQ9");

      await builder.Build().RunAsync();
    }
  }
}