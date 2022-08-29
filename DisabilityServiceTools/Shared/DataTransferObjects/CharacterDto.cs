using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace CampaignsWithoutNumber.Shared.DataTransferObjects
{
  public sealed class CharacterDto
  {
    public string Id { get; set; }

    public int HitPoints { get; set; }

    public int AttackBonus { get; set; }

    public int Level { get; set; }

    public int SkillPoints { get; set; }

    [Required(ErrorMessage = "Name is required.")]
    public string Name { get; set; }
    
    public List<CharacterClassDto>? Classes { get; set; }
  }
}