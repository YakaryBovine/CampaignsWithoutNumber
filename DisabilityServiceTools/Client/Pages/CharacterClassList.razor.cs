using System.Collections.Generic;
using System.Net.Http.Json;
using System.Threading.Tasks;
using CampaignsWithoutNumber.Shared.DataTransferObjects;

namespace CampaignsWithoutNumber.Client.Pages
{
  public partial class CharacterClassList
  {
    private IEnumerable<CharacterClassDto> _characterClasses = new List<CharacterClassDto>();

    protected override async Task OnInitializedAsync()
    {
      _characterClasses = await _httpClient.GetFromJsonAsync<List<CharacterClassDto>>("api/characterclass/index");
    }
  }
}