using CampaignsWithoutNumber.Shared.DataTransferObjects;
using CampaignsWithoutNumber.Shared.Entities;
using CampaignsWithoutNumber.Shared.Managers;

namespace CampaignsWithoutNumber.Shared.Mappers
{
	public static class AttributeMapper
	{
		public static IAttribute ToEntity(AttributeDto dto)
		{
			var entity = AttributeManager.GetById(dto.Id);
			entity.Value = dto.Value;
			return entity;
		}
		
		public static AttributeDto ToDto(IAttribute entity)
		{
			var dto = new AttributeDto(entity.Id, entity.Name, entity.Description)
			{
				Value = entity.Value
			};
			return dto;
		}
	}
}