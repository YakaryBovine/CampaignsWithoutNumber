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
	public class ExamClientRepository : IExamClientRepository
	{
		private readonly HttpClient _client;
		private readonly JsonSerializerOptions _options;

		public ExamClientRepository(HttpClient client)
		{
			_client = client;
			_options = new JsonSerializerOptions { PropertyNameCaseInsensitive = true };
		}

		public async Task<Exam> GetExam(int id)
		{
			var uri = $"api/exams/{id}";
      using var response = await _client.GetAsync(uri);
      response.EnsureSuccessStatusCode();
      var stream = await response.Content.ReadAsStreamAsync();
      var product = await JsonSerializer.DeserializeAsync<Exam>(stream, _options);
      return product;
    }

		public async Task<PagingResponse<Exam>> GetExams(ExamParameters studentParameters)
		{
			var queryStringParam = new Dictionary<string, string>
			{
				["pageNumber"] = studentParameters.PageNumber.ToString(),
				["pageSize"] = studentParameters.PageSize.ToString(),
				["searchTerm"] = studentParameters.SearchTerm ?? "",
				["orderBy"] = studentParameters.OrderBy ?? "name"
			};

			var requestUrl = QueryHelpers.AddQueryString("api/exams", queryStringParam);
      using var response = await _client.GetAsync(requestUrl);
      response.EnsureSuccessStatusCode();

      var metaData = JsonSerializer
        .Deserialize<PagingMetaData>(response.Headers.GetValues("X-Pagination").First(), _options);

      var stream = await response.Content.ReadAsStreamAsync();

      var pagingResponse = new PagingResponse<Exam>
      {
        Items = await JsonSerializer.DeserializeAsync<List<Exam>>(stream, _options),
        MetaData = metaData
      };

      return pagingResponse;
    }
	}
}