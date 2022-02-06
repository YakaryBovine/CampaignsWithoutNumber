using DisabilityServiceTools.Shared.RequestFeatures;
using System.Collections.Generic;

namespace DisabilityServiceTools.Client.Features
{
	public class PagingResponse<T> where T : class
	{
		public List<T> Items { get; set; }
		public PagingMetaData MetaData { get; set; }
	}
}