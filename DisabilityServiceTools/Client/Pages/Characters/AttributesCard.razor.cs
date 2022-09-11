using System.Collections.Generic;
using System.Net.Http.Json;
using System.Threading.Tasks;
using CampaignsWithoutNumber.Shared.DataTransferObjects;
using Microsoft.AspNetCore.Components;

namespace CampaignsWithoutNumber.Client.Pages.Characters;

/// <summary>
///   Allows the user to pick their Attributes.
/// </summary>
public partial class AttributesCard
{
  [Parameter] public IEnumerable<AttributeDto> Attributes { get; set; }

  [Parameter] public EventCallback OnClose { get; set; }
}