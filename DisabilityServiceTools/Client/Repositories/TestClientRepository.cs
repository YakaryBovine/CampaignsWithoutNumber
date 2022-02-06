using DisabilityServiceTools.Client.Features;
using DisabilityServiceTools.Shared.Models;
using DisabilityServiceTools.Shared.RequestFeatures;
using Microsoft.AspNetCore.WebUtilities;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Json;
using System.Text.Json;
using System.Threading.Tasks;

namespace DisabilityServiceTools.Client.Repositories
{
	public class TestClientRepository : ITestClientRepository
	{
		private readonly HttpClient _client;
		private readonly JsonSerializerOptions _options;

		public TestClientRepository(HttpClient client)
		{
			_client = client;
			_options = new JsonSerializerOptions { PropertyNameCaseInsensitive = true };
		}

		public async Task CreateTest(Test test)
		=> await _client.PostAsJsonAsync("api/tests", test);

		public async Task<Test> GetTest(int id)
		{
			var uri = $"api/tests/{id}";
      using var response = await _client.GetAsync(uri);
      response.EnsureSuccessStatusCode();
      var stream = await response.Content.ReadAsStreamAsync();
      var product = await JsonSerializer.DeserializeAsync<Test>(stream, _options);
      return product;
    }

		public async Task<PagingResponse<Test>> GetTests(TestParameters studentParameters)
		{
			var queryStringParam = new Dictionary<string, string>
			{
				["pageNumber"] = studentParameters.PageNumber.ToString(),
				["pageSize"] = studentParameters.PageSize.ToString(),
				["searchTerm"] = studentParameters.SearchTerm ?? "",
				["orderBy"] = studentParameters.OrderBy ?? "name"
			};

			var requestUrl = QueryHelpers.AddQueryString("api/tests", queryStringParam);
      using var response = await _client.GetAsync(requestUrl);
      response.EnsureSuccessStatusCode();

      var metaData = JsonSerializer
        .Deserialize<PagingMetaData>(response.Headers.GetValues("X-Pagination").First(), _options);

      var stream = await response.Content.ReadAsStreamAsync();

      var pagingResponse = new PagingResponse<Test>
      {
        Items = await JsonSerializer.DeserializeAsync<List<Test>>(stream, _options),
        MetaData = metaData
      };

      return pagingResponse;
    }
	}
}