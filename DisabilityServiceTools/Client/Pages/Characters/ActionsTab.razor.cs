using CampaignsWithoutNumber.Shared.DataTransferObjects;
using Microsoft.AspNetCore.Components;

namespace CampaignsWithoutNumber.Client.Pages.Characters;

public partial class ActionsTab
{
	[Parameter] public CharacterDto Character { get; set; }
}