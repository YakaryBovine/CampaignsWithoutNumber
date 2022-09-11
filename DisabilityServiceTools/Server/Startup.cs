using System.Linq;
using CampaignsWithoutNumber.Shared.Classes;
using CampaignsWithoutNumber.Shared.Managers;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.ResponseCompression;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using MongoDB.Bson.Serialization;
using Newtonsoft.Json;

namespace CampaignsWithoutNumber.Server
{
  public class Startup
  {
    public Startup(IConfiguration configuration)
    {
      Configuration = configuration;
    }

    private IConfiguration Configuration { get; }

    // This method gets called by the runtime. Use this method to add services to the container.
    // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940
    public void ConfigureServices(IServiceCollection services)
    {
      services.AddControllersWithViews()
        .AddNewtonsoftJson(options =>
          options.SerializerSettings.ReferenceLoopHandling = ReferenceLoopHandling.Ignore
        );
      services.AddRazorPages();
      services.AddSignalR();
      services.AddResponseCompression(opts =>
      {
        opts.MimeTypes = ResponseCompressionDefaults.MimeTypes.Concat(
          new[] { "application/octet-stream" });
      });
      RegisterClassMaps();
      CreateCharacterClasses();
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
        endpoints.MapFallbackToFile("index.html");
      });
    }
    
    private static void CreateCharacterClasses()
    {
      CharacterClassManager.Register(new Warrior());
      CharacterClassManager.Register(new Expert());
      CharacterClassManager.Register(new Psychic());
      CharacterClassManager.Register(new Warlock());
    }
    
    private static void RegisterClassMaps()
    {
      BsonClassMap.RegisterClassMap<Warrior>();
      BsonClassMap.RegisterClassMap<Psychic>();
      BsonClassMap.RegisterClassMap<Expert>();
      BsonClassMap.RegisterClassMap<Warlock>();
    }
  }
}