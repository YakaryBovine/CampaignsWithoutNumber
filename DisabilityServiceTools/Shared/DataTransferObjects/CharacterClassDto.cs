﻿using System.Collections.Generic;
using CampaignsWithoutNumber.Shared.Entities;

namespace CampaignsWithoutNumber.Shared.DataTransferObjects
{
  public class CharacterClassDto
  {
    public string Id { get; set; }

    public string Name { get; set; }
    
    public float AttackBonusPerLevel { get; set; }
    
    public float HitPointsPerLevel { get; set; }
    
    public List<CharacterFeatureDto> Features { get; set; }
    
    public override int GetHashCode() => Name?.GetHashCode() ?? 0;
    
    public override string ToString() => Name;
  }
}