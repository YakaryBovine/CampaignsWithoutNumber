using System.Collections.Generic;
using System.Net.Http.Json;
using System.Threading.Tasks;
using CampaignsWithoutNumber.Shared.Entities;

namespace CampaignsWithoutNumber.Client.Pages
{
  public partial class ShipDefenseView
  {
    private IEnumerable<ShipDefense> _shipDefenses = new List<ShipDefense>();

    protected override async Task OnInitializedAsync()
    {
      _shipDefenses = await _httpClient.GetFromJsonAsync<List<ShipDefense>>("api/shipdefense/index");
    }
  }
}