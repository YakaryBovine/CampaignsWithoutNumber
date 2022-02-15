using System.Collections.Generic;
using System.Net.Http.Json;
using System.Threading.Tasks;
using CampaignsWithoutNumber.Shared.Models;

namespace CampaignsWithoutNumber.Client.Pages.Characters
{
  public partial class CharacterList
  {
    private IEnumerable<Character> _characters = new List<Character>();

    protected override async Task OnInitializedAsync()
    {
      _characters = await _httpClient.GetFromJsonAsync<List<Character>>("api/character/index");
    }
  }
}