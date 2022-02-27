using System.Collections.Generic;
using System.Net.Http.Json;
using System.Threading.Tasks;
using CampaignsWithoutNumber.Shared.DataTransferObjects;

namespace CampaignsWithoutNumber.Client.Pages.Characters
{
  public partial class CharacterList
  {
    private IEnumerable<CharacterDto> _characters = new List<CharacterDto>();

    protected override async Task OnInitializedAsync()
    {
      _characters = await _httpClient.GetFromJsonAsync<List<CharacterDto>>("api/character/index");
    }
  }
}