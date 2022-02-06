using System;
using System.Net.Http;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using Microsoft.Extensions.DependencyInjection;
using DisabilityServiceTools.Client.Repositories;
using MudBlazor.Services;

namespace DisabilityServiceTools.Client
{
  public class Program
  {
    public static async Task Main(string[] args)
    {
      var builder = WebAssemblyHostBuilder.CreateDefault(args);
      builder.RootComponents.Add<App>("app");

      builder.Services.AddTransient(sp => new HttpClient { BaseAddress = new Uri(builder.HostEnvironment.BaseAddress) });
      builder.Services.AddMudServices();
      builder.Services.AddScoped<IStudentClientRepository, StudentClientRepository>();
      builder.Services.AddScoped<ITestClientRepository, TestClientRepository>();
      builder.Services.AddScoped<IExamClientRepository, ExamClientRepository>();
      builder.Services.AddScoped<ICourseClientRepository, CourseClientRepository>();
      builder.Services.AddScoped<ITestArrangementClientRepository, TestArrangementClientRepository>();
      builder.Services.AddScoped<IExamArrangementClientRepository, ExamArrangementClientRepository>();
      builder.Services.AddScoped<ISupportStaffClientRepository, SupportStaffClientRepository>();

      await builder.Build().RunAsync();
    }
  }
}