using CampaignsWithoutNumber.Shared.DataTransferObjects;
using System.Net.Http.Json;

namespace CampaignsWithoutNumber.Server.IntegrationTests;

public sealed class CharacterControllerTests : IClassFixture<WebApplicationFactory<Program>>
{
  private readonly HttpClient _client;

  public CharacterControllerTests(WebApplicationFactory<Program> application)
  {
    _client = application.CreateClient();
  }
  
  [Fact]
  public async Task Get_ReturnsValidCharacter()
  {
    var mapData = await _client.GetFromJsonAsync<IEnumerable<CharacterDto>>("api/character/index");
    mapData.Should().NotBeNull();
  }
}