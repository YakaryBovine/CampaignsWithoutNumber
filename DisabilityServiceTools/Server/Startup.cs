﻿using System.Linq;
using CampaignsWithoutNumber.Server.Services;
using CampaignsWithoutNumber.Shared.Classes;
using CampaignsWithoutNumber.Shared.Entities;
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
      CreateDummyData();
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
    
    private static void CreateDummyData()
    {
      var shipDefenseService = new ShipDefenseService();
      shipDefenseService.AddShipDefense(new ShipDefense
        {
          Name = "Ablative Hull Compartments",
          Cost = 100000,
          Power = 5,
          Mass = 2,
          Class = ShipClass.Capital,
          ShortDescription = "+1 AC, +20 maximum hit points",
          LongDescription = @"By sacrificing empty hull
          space in a complex system of ablative blast baffles,
          a capital-class ship can have a large amount of its
          total mass shot away without actually impinging
          on its normal function. This grants it a +1 AC
          bonus and 20 extra maximum hit points."
        }
      );
      shipDefenseService.AddShipDefense(new ShipDefense
        {
          Name = "Augmented Platings",
          Cost = 25000,
          Power = 0,
          Mass = 1,
          Class = ShipClass.Fighter,
          ShortDescription = "+2 AC, -1 Speed",
          LongDescription = @"At the cost of a certain amount of
          speed and maneuverability, a ship can have its armor
          plating reinforced against glancing hits, gaining
          a +2 bonus to its AC. This augmentation can
          decrease a ship’s Speed below 0, meaning it will
          be applied as a penalty to all Pilot tests."
        }
      );

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