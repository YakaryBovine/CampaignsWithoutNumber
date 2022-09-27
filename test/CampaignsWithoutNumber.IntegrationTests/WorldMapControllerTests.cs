using CampaignsWithoutNumber.Shared.DataTransferObjects;
using System.Net.Http.Json;

namespace CampaignsWithoutNumber.Server.IntegrationTests;

public sealed class WorldMapControllerTests : IClassFixture<WebApplicationFactory<Program>>
{
  private readonly HttpClient _client;

  public WorldMapControllerTests(WebApplicationFactory<Program> application)
  {
    _client = application.CreateClient();
  }

  [Fact]
  public async Task Get_ReturnsValidWorldMap()
  {
    var mapData = await _client.GetFromJsonAsync<WorldMapDto>("api/worldmap/index");
    mapData.Should().NotBeNull();
  }
}