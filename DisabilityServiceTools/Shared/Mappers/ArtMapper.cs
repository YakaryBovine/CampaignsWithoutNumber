using CampaignsWithoutNumber.Shared.DataTransferObjects;
using CampaignsWithoutNumber.Shared.Entities;

namespace CampaignsWithoutNumber.Shared.Mappers
{
	public static class ArtMapper
	{
		public static Art ToEntity(ArtDto dto)
		{
			return new Art(dto.Name, dto.Description);
		}
		
		public static ArtDto ToDto(Art entity)
		{
			return new ArtDto
			{
				Name = entity.Name,
				Description = entity.Description
			};
		}
	}
}