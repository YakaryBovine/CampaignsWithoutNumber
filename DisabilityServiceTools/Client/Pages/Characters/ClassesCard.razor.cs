using System;
using System.Collections.Generic;
using System.Net.Http.Json;
using System.Threading.Tasks;
using CampaignsWithoutNumber.Shared.DataTransferObjects;
using MudBlazor;

namespace CampaignsWithoutNumber.Client.Pages.Characters
{
  /// <summary>
  /// Allows the user to select character classes from a list.
  /// </summary>
  public partial class ClassesCard
  {
    private IEnumerable<CharacterClassDto> _characterClasses = new List<CharacterClassDto>();

    private CharacterClassDto _value;

    private HashSet<CharacterClassDto> _selectedValues;

    private Func<CharacterClassDto,string> _converter = p => p?.Name;
    
    protected override async Task OnInitializedAsync()
    {
      _characterClasses = await HttpClient.GetFromJsonAsync<List<CharacterClassDto>>("api/characterclass/index");
    }
  }
}