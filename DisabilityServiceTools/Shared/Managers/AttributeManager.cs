using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using CampaignsWithoutNumber.Shared.Entities;

namespace CampaignsWithoutNumber.Shared.Managers
{
	public static class AttributeManager
	{
		private static readonly Dictionary<string, IAttribute> AttributesById = new();

		public static IEnumerable<IAttribute> GetAll() => AttributesById.Values.ToList().AsReadOnly();
		
		public static void Register(IAttribute attribute)
		{
			AttributesById.Add(attribute.Id, attribute);
		}
		
		public static IAttribute GetById(string id) => AttributesById[id];
	}
}