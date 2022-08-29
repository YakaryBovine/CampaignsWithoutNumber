using System.Collections.Generic;
using System.Net.Http.Json;
using System.Threading.Tasks;
using CampaignsWithoutNumber.Shared.DataTransferObjects;
using Microsoft.AspNetCore.Components;

namespace CampaignsWithoutNumber.Client.Pages.Characters;

/// <summary>
///   Allows the user to select character classes from a list.
/// </summary>
public partial class ClassesCard
{
  private IEnumerable<CharacterClassDto> _characterClasses = new List<CharacterClassDto>();

  private CharacterClassDto value { get; set; }

  [Parameter] public CharacterDto Character { get; set; }

  [Parameter] public EventCallback OnClose { get; set; }

  private void Closed()
  {
    OnClose.InvokeAsync();
  }

  protected override async Task OnInitializedAsync()
  {
    _characterClasses = await HttpClient.GetFromJsonAsync<List<CharacterClassDto>>("api/characterclass/index");
  }
}