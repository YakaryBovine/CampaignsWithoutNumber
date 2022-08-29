using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Json;
using System.Threading.Tasks;
using CampaignsWithoutNumber.Shared.DataTransferObjects;
using Microsoft.AspNetCore.Components;
using MudBlazor;

namespace CampaignsWithoutNumber.Client.Pages.Characters
{
  /// <summary>
  /// Allows the user to select character classes from a list.
  /// </summary>
  public partial class ClassesCard
  {
    private IEnumerable<CharacterClassDto> _characterClasses = new List<CharacterClassDto>();

    private Func<CharacterClassDto,string> _converter = p => p?.Name;

    [Parameter]
    public CharacterDto Character { get; set; }
    
    [Parameter] 
    public EventCallback OnSelectedClassesChanged { get; set; }

    private void SelectedClassesChanged(HashSet<CharacterClassDto> values)
    {
      Character.Classes = values.ToList();
      OnSelectedClassesChanged.InvokeAsync(values);
    }
    
    protected override async Task OnInitializedAsync()
    {
      _characterClasses = await HttpClient.GetFromJsonAsync<List<CharacterClassDto>>("api/characterclass/index");
    }
  }
}