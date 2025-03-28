using CampaignsWithoutNumber.Infrastructure.Repositories;

// ReSharper disable once CheckNamespace
namespace Microsoft.Extensions.DependencyInjection
{
  public static class StartupExtensions
  {
    public static IServiceCollection AddInfrastructure(this IServiceCollection services)
    {
      services.AddScoped<ICharacterRepository, CharacterRepository>();
      return services;
    }
  }
}