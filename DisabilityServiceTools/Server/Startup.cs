using System;
using System.Linq;
using CampaignsWithoutNumber.Shared;
using CampaignsWithoutNumber.Shared.Entities;
using CampaignsWithoutNumber.Shared.Entities.Attributes;
using CampaignsWithoutNumber.Shared.Entities.Classes;
using CampaignsWithoutNumber.Shared.Managers;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.ResponseCompression;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using MongoDB.Bson.Serialization;
using Newtonsoft.Json;
using Syncfusion.Blazor;

namespace CampaignsWithoutNumber.Server;

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
    services.AddSyncfusionBlazor();
    services.AddResponseCompression(opts =>
    {
      opts.MimeTypes = ResponseCompressionDefaults.MimeTypes.Concat(
        new[] { "application/octet-stream" });
    });
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
    var characterClassImplementingAttribute = AppDomain.CurrentDomain.GetAssemblies().SelectMany(x => x.GetTypes())
      .Where(mytype =>
        typeof(ICharacterClass).IsAssignableFrom(mytype) && mytype.GetInterfaces().Contains(typeof(ICharacterClass)));
    foreach (var characterClassType in characterClassImplementingAttribute)
    {
      BsonClassMap.LookupClassMap(characterClassType);
      CharacterClassManager.Register((ICharacterClass?)Activator.CreateInstance(characterClassType) ?? throw new InvalidOperationException());
    }
    
    var typesImplementingAttribute = AppDomain.CurrentDomain.GetAssemblies().SelectMany(x => x.GetTypes())
      .Where(mytype =>
        typeof(IAttribute).IsAssignableFrom(mytype) && mytype.GetInterfaces().Contains(typeof(IAttribute)));
    foreach (var attributeType in typesImplementingAttribute)
    {
      BsonClassMap.LookupClassMap(attributeType);
      AttributeManager.Register((IAttribute?)Activator.CreateInstance(attributeType) ?? throw new InvalidOperationException());
    }

    var typesImplementingArt = AppDomain.CurrentDomain.GetAssemblies().SelectMany(x => x.GetTypes())
      .Where(mytype =>
        typeof(IArt).IsAssignableFrom(mytype) && mytype.GetInterfaces().Contains(typeof(IArt)));
    foreach (var artType in typesImplementingArt)
    {
      BsonClassMap.LookupClassMap(artType);
      ArtManager.Register((IArt?)Activator.CreateInstance(artType) ?? throw new InvalidOperationException());
    }
  }
}