using System.Collections.Generic;
using System.Net.Http.Json;
using System.Threading.Tasks;
using CampaignsWithoutNumber.Shared.DataTransferObjects;
using Microsoft.AspNetCore.Components;
using MudBlazor;

namespace CampaignsWithoutNumber.Client.Pages.Characters
{
  public partial class CharacterCreate
  {
    private readonly CharacterDto _character = new();

    [Inject] public IDialogService Dialog { get; set; }
    [Inject] public NavigationManager NavManager { get; set; }

    private async Task Create()
    {
      await HttpClient.PostAsJsonAsync("api/character/create", _character);
      await ExecuteDialog();
    }

    private async Task ExecuteDialog()
    {
      var parameters = new DialogParameters
      {
        {"Content", "Character successfuly created."},
        {"ButtonColor", Color.Primary},
        {"ButtonText", "OK"}
      };
      var dialog = Dialog.Show<DialogNotification>("Success", parameters);
      var result = await dialog.Result;
      if (!result.Cancelled)
      {
        bool.TryParse(result.Data.ToString(), out bool shouldNavigate);
        if (shouldNavigate)
          NavManager.NavigateTo("/characterlist");
      }
    }
    
    protected override async Task OnInitializedAsync()
    {
      await HttpClient.GetFromJsonAsync<List<CharacterClassDto>>("api/characterclass/index");
    }
  }
}