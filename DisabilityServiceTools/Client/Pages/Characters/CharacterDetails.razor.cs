using System.Net.Http.Json;
using System.Threading.Tasks;
using CampaignsWithoutNumber.Shared.DataTransferObjects;
using Microsoft.AspNetCore.Components;

namespace CampaignsWithoutNumber.Client.Pages.Characters
{
  public partial class CharacterDetails
  {
    private CharacterDto Character { get; set; } = new();

    [Parameter]
    public string Id { get; set; }
    
    private async void Save()
    {
      await HttpClient.PostAsJsonAsync("api/character/edit", Character);
    }
    
    protected override async Task OnInitializedAsync()
    {
      Character = await HttpClient.GetFromJsonAsync<CharacterDto>($"api/character/details/{Id}");
    }
  }
}