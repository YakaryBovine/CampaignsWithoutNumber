using Syncfusion.Blazor;

namespace CampaignsWithoutNumber.Client
{
  public sealed class SampleLocalizer : ISyncfusionStringLocalizer
  {

    public string? GetText(string key) => ResourceManager.GetString(key);

    public System.Resources.ResourceManager ResourceManager => Resources.SfResources.ResourceManager;
  }
}