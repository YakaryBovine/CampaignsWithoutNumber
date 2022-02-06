using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.ResponseCompression;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using DisabilityServiceTools.Server.Repositories;
using DisabilityServiceTools.Server.Data;
using DisabilityServiceTools.Server.Hubs;

namespace DisabilityServiceTools.Server
{
  public class Startup
  {
    public Startup(IConfiguration configuration)
    {
      Configuration = configuration;
    }

    public IConfiguration Configuration { get; }

    // This method gets called by the runtime. Use this method to add services to the container.
    // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940
    public void ConfigureServices(IServiceCollection services)
    {

      services.AddControllersWithViews()
          .AddNewtonsoftJson(options =>
          options.SerializerSettings.ReferenceLoopHandling = Newtonsoft.Json.ReferenceLoopHandling.Ignore
      );
      services.AddRazorPages();
      services.AddSignalR();
      services.AddResponseCompression(opts =>
      {
        opts.MimeTypes = ResponseCompressionDefaults.MimeTypes.Concat(
                  new[] { "application/octet-stream" });
      });

      services.AddDbContext<DisabilityServiceDBContext>(options =>
              options.UseSqlServer(Configuration.GetConnectionString("DisabilityServiceDBContext")));
      services.AddScoped<IStudentRepository, StudentRepository>();
      services.AddScoped<ITestRepository, TestRepository>();
      services.AddScoped<IExamRepository, ExamRepository>();
      services.AddScoped<ICourseRepository, CourseRepository>();
      services.AddScoped<ITestArrangementRepository, TestArrangementRepository>();
      services.AddScoped<IExamArrangementRepository, ExamArrangementRepository>();
      services.AddScoped<ISupportStaffRepository, SupportStaffRepository>();
    }

    // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
    public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
    {
      if (env.IsDevelopment())
      {
        app.UseDeveloperExceptionPage();
        app.UseWebAssemblyDebugging();
      }
      else
      {
        app.UseExceptionHandler("/Error");
      }

      app.UseBlazorFrameworkFiles();
      app.UseStaticFiles();

      app.UseRouting();

      app.UseEndpoints(endpoints =>
      {
        endpoints.MapRazorPages();
        endpoints.MapControllers();
        endpoints.MapHub<BroadcastHub>("/broadcastHub");
        endpoints.MapFallbackToFile("index.html");
      });
    }
  }
}
