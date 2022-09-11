using CampaignsWithoutNumber.Shared.DataTransferObjects;
using Microsoft.AspNetCore.Components;

namespace CampaignsWithoutNumber.Client.Pages.Characters;

/// <summary>
///    Allows the user to select character classes from a list.
/// </summary>
public partial class ArtsCard
{
	private CharacterClassDto value { get; set; }

	[Parameter] public CharacterClassDto CharacterClass { get; set; }

	[Parameter] public EventCallback OnClose { get; set; }

	private void Closed()
	{
		OnClose.InvokeAsync();
	}
}