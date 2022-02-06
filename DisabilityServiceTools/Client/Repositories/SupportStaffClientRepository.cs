using DisabilityServiceTools.Client.Features;
using DisabilityServiceTools.Shared.Models;
using DisabilityServiceTools.Shared.RequestFeatures;
using Microsoft.AspNetCore.WebUtilities;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text.Json;
using System.Threading.Tasks;

namespace DisabilityServiceTools.Client.Repositories
{
	public class SupportStaffClientRepository : ISupportStaffClientRepository
	{
		private readonly HttpClient _client;
		private readonly JsonSerializerOptions _options;

		public SupportStaffClientRepository(HttpClient client)
		{
			_client = client;
			_options = new JsonSerializerOptions { PropertyNameCaseInsensitive = true };
		}

		public async Task<SupportStaff> GetSupportStaff(int id)
		{
			var uri = $"api/supportstaffs/{id}";
      using var response = await _client.GetAsync(uri);
      response.EnsureSuccessStatusCode();
      var stream = await response.Content.ReadAsStreamAsync();
      var product = await JsonSerializer.DeserializeAsync<SupportStaff>(stream, _options);
      return product;
    }

		public async Task<PagingResponse<SupportStaff>> GetSupportStaffs(SupportStaffParameters studentParameters)
		{
			var queryStringParam = new Dictionary<string, string>
			{
				["pageNumber"] = studentParameters.PageNumber.ToString(),
				["pageSize"] = studentParameters.PageSize.ToString(),
				["searchTerm"] = studentParameters.SearchTerm ?? "",
				["orderBy"] = studentParameters.OrderBy ?? "name"
			};

			var requestUrl = QueryHelpers.AddQueryString("api/supportstaffs", queryStringParam);
      using var response = await _client.GetAsync(requestUrl);
      response.EnsureSuccessStatusCode();

      var metaData = JsonSerializer
        .Deserialize<PagingMetaData>(response.Headers.GetValues("X-Pagination").First(), _options);

      var stream = await response.Content.ReadAsStreamAsync();

      var pagingResponse = new PagingResponse<SupportStaff>
      {
        Items = await JsonSerializer.DeserializeAsync<List<SupportStaff>>(stream, _options),
        MetaData = metaData
      };

      return pagingResponse;
    }
	}
}