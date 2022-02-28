using System;
using CampaignsWithoutNumber.Shared.DataTransferObjects;
using CampaignsWithoutNumber.Shared.Entities;
using CampaignsWithoutNumber.Shared.Entities.CharacterFeatures;

namespace CampaignsWithoutNumber.Shared.Mappers
{
  public static class CharacterFeatureMapper
  {
    public static CharacterFeature ToEntity(CharacterFeatureDto dto)
    {
      return dto.Name switch
      {
        nameof(MasterfulExpertise) => new MasterfulExpertise(),
        nameof(QuickLearner) => new QuickLearner(),
        nameof(VeteransLuck) => new VeteransLuck(),
        _ => throw new InvalidOperationException($"Could not find a matching Feature for {dto.Name} on the server.")
      };
    }

    public static CharacterFeatureDto ToDto(CharacterFeature entity)
    {
      return new CharacterFeatureDto(entity.ClassName);
    }
  }
}