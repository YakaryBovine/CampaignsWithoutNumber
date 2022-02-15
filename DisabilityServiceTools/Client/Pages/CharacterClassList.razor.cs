using System.Collections.Generic;
using System.Net.Http.Json;
using System.Threading.Tasks;
using CampaignsWithoutNumber.Shared.Models;

namespace CampaignsWithoutNumber.Client.Pages
{
  public partial class CharacterClassList
  {
    private IEnumerable<CharacterClass> _characterClasses = new List<CharacterClass>();

    protected override async Task OnInitializedAsync()
    {
      _characterClasses = await _httpClient.GetFromJsonAsync<List<CharacterClass>>("api/characterclass/index");
    }
  }
}