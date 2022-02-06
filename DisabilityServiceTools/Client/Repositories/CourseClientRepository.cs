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
	public class CourseClientRepository : ICourseClientRepository
	{
		private readonly HttpClient _client;
		private readonly JsonSerializerOptions _options;

		public CourseClientRepository(HttpClient client)
		{
			_client = client;
			_options = new JsonSerializerOptions { PropertyNameCaseInsensitive = true };
		}

		public async Task<Course> GetCourse(int id)
		{
			var uri = $"api/courses/{id}";
      using var response = await _client.GetAsync(uri);
      response.EnsureSuccessStatusCode();
      var stream = await response.Content.ReadAsStreamAsync();
      var product = await JsonSerializer.DeserializeAsync<Course>(stream, _options);
      return product;
    }

		public async Task<PagingResponse<Course>> GetCourses(CourseParameters courseParameters)
		{
			var queryStringParam = new Dictionary<string, string>
			{
				["pageNumber"] = courseParameters.PageNumber.ToString(),
				["pageSize"] = courseParameters.PageSize.ToString(),
				["searchTerm"] = courseParameters.SearchTerm ?? "",
				["orderBy"] = courseParameters.OrderBy ?? "code"
			};

			var requestUrl = QueryHelpers.AddQueryString("api/courses", queryStringParam);
      using var response = await _client.GetAsync(requestUrl);
      response.EnsureSuccessStatusCode();

      var metaData = JsonSerializer
        .Deserialize<PagingMetaData>(response.Headers.GetValues("X-Pagination").First(), _options);

      var stream = await response.Content.ReadAsStreamAsync();

      var pagingResponse = new PagingResponse<Course>
      {
        Items = await JsonSerializer.DeserializeAsync<List<Course>>(stream, _options),
        MetaData = metaData
      };

      return pagingResponse;
    }
	}
}