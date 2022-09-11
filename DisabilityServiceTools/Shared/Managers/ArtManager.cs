using System.Collections.Generic;
using CampaignsWithoutNumber.Shared.Entities;

namespace CampaignsWithoutNumber.Shared.Managers
{
	public static class ArtManager
	{
		private static readonly Dictionary<string, IArt> ArtsById = new();
    
		public static void Register(IArt art)
		{
			ArtsById.Add(art.Id, art);
		}
		
		public static IArt GetById(string id) => ArtsById[id];
	}
}