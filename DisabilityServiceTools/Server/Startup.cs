using System.Collections.Generic;
using System.Linq;
using CampaignsWithoutNumber.Server.Services;
using CampaignsWithoutNumber.Shared.CharacterFeatures;
using CampaignsWithoutNumber.Shared.Models;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.ResponseCompression;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

namespace CampaignsWithoutNumber.Server
{
  public class Startup
  {
    public Startup(IConfiguration configuration)
    {
      Configuration = configuration;
    }

    private IConfiguration Configuration { get; }

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
      var characterClassService = new CharacterClassService();
      
      var warrior = new CharacterClass
      {
        Name = "Warrior",
        HitPointsPerLevel = 5.5f,
        AttackBonusPerLevel = 1f,
        Features = new List<CharacterFeature>
        {
          new VeteransLuck()
        }
      };
      characterClassService.AddCharacterClass(warrior);

      var expert = new CharacterClass
      {
        Name = "Expert",
        HitPointsPerLevel = 3.5f,
        AttackBonusPerLevel = 0.5f,
        Features = new List<CharacterFeature>
        {
          new MasterfulExpertise(),
          new QuickLearner()
        }
      };
      characterClassService.AddCharacterClass(expert);

      var psychic = new CharacterClass
      {
        Name = "Psychic",
        HitPointsPerLevel = 3.5f,
        AttackBonusPerLevel = 0.5f,
        Features = new List<CharacterFeature>
        {
          new VeteransLuck()
        }
      };
      characterClassService.AddCharacterClass(psychic);
    }

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
          new[] {"application/octet-stream"});
      });
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
  }
}