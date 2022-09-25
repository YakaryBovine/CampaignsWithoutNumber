using System;
using System.Linq;
using CampaignsWithoutNumber.Shared;
using CampaignsWithoutNumber.Shared.Entities;
using CampaignsWithoutNumber.Shared.Managers;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.ResponseCompression;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using MongoDB.Bson.Serialization;
using Newtonsoft.Json;

namespace CampaignsWithoutNumber.Server;

public static class Program
{
  public static void Main(string[] args)
  {
    var builder = WebApplication.CreateBuilder(args);

    // Add services to the container.
    builder.Services.AddControllersWithViews()
      .AddNewtonsoftJson(options =>
        options.SerializerSettings.ReferenceLoopHandling = ReferenceLoopHandling.Ignore
      );
    builder.Services.AddRazorPages();
    builder.Services.AddSignalR();
    builder.Services.AddResponseCompression(opts =>
    {
      opts.MimeTypes = ResponseCompressionDefaults.MimeTypes.Concat(
        new[] { "application/octet-stream" });
    });
    CreateCharacterClasses();

    var app = builder.Build();

    // Configure the HTTP request pipeline.
    if (!app.Environment.IsDevelopment())
    {
      app.UseExceptionHandler("/Error");
      // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
      app.UseHsts();
    }

    if (builder.Environment.IsDevelopment())
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

    app.Run();
  }

  private static void CreateCharacterClasses()
  {
    var characterClassImplementingAttribute = AppDomain.CurrentDomain.GetAssemblies().SelectMany(x => x.GetTypes())
      .Where(mytype =>
        typeof(ICharacterClass).IsAssignableFrom(mytype) && mytype.GetInterfaces().Contains(typeof(ICharacterClass)));
    foreach (var characterClassType in characterClassImplementingAttribute)
    {
      BsonClassMap.LookupClassMap(characterClassType);
      CharacterClassManager.Register((ICharacterClass?)Activator.CreateInstance(characterClassType) ??
                                     throw new InvalidOperationException());
    }

    var typesImplementingAttribute = AppDomain.CurrentDomain.GetAssemblies().SelectMany(x => x.GetTypes())
      .Where(mytype =>
        typeof(IAttribute).IsAssignableFrom(mytype) && mytype.GetInterfaces().Contains(typeof(IAttribute)));
    foreach (var attributeType in typesImplementingAttribute)
    {
      BsonClassMap.LookupClassMap(attributeType);
      AttributeManager.Register((IAttribute?)Activator.CreateInstance(attributeType) ??
                                throw new InvalidOperationException());
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