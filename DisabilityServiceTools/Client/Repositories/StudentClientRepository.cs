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
  public class StudentClientRepository : IStudentClientRepository
  {
    private readonly HttpClient _client;
    private readonly JsonSerializerOptions _options;

    public StudentClientRepository(HttpClient client)
    {
      _client = client;
      _options = new JsonSerializerOptions { PropertyNameCaseInsensitive = true };
    }

    public async Task Create(Student student)
    {
      await _client.PostAsJsonAsync("api/students", student);
    }

    public async Task<Student> GetStudent(int id)
    {
      var uri = $"api/students/{id}";
      using var response = await _client.GetAsync(uri);
      response.EnsureSuccessStatusCode();
      var stream = await response.Content.ReadAsStreamAsync();
      var product = await JsonSerializer.DeserializeAsync<Student>(stream, _options);
      return product;
    }

    public async Task<PagingResponse<Student>> GetStudents(StudentParameters studentParameters)
    {
      var queryStringParam = new Dictionary<string, string>
      {
        ["pageNumber"] = studentParameters.PageNumber.ToString(),
        ["pageSize"] = studentParameters.PageSize.ToString(),
        ["searchTerm"] = studentParameters.SearchTerm ?? "",
        ["orderBy"] = studentParameters.OrderBy ?? "name"
      };

      var requestUrl = QueryHelpers.AddQueryString("api/students", queryStringParam);
      using var response = await _client.GetAsync(requestUrl);
      response.EnsureSuccessStatusCode();

      var metaData = JsonSerializer
        .Deserialize<PagingMetaData>(response.Headers.GetValues("X-Pagination").First(), _options);

      var stream = await response.Content.ReadAsStreamAsync();

      var pagingResponse = new PagingResponse<Student>
      {
        Items = await JsonSerializer.DeserializeAsync<List<Student>>(stream, _options),
        MetaData = metaData
      };

      return pagingResponse;
    }
  }
}