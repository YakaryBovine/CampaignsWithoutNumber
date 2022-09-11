using CampaignsWithoutNumber.Shared.DataTransferObjects;
using CampaignsWithoutNumber.Shared.Entities;
using CampaignsWithoutNumber.Shared.Managers;

namespace CampaignsWithoutNumber.Shared.Mappers
{
	public static class ArtMapper
	{
		public static IArt ToEntity(ArtDto dto)
		{
			return ArtManager.GetById(dto.Id);
		}
		
		public static ArtDto ToDto(IArt entity)
		{
			return new ArtDto(entity.Id)
			{
				Name = entity.Name,
				Description = entity.Description
			};
		}
	}
}