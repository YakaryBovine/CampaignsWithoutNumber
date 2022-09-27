namespace CampaignsWithoutNumber.Server.IntegrationTests;

public class WorldMapControllerTests : IClassFixture<WebApplicationFactory<Program>>
{
  private readonly HttpClient _client;

  public WorldMapControllerTests(WebApplicationFactory<Program> application)
  {
    _client = application.CreateClient();
  }
  
  [Fact]
  public async Task Get_ReturnsOk()
  {
    var response = await _client.GetAsync("/worldmap/get");
    response.StatusCode.Should().Be(HttpStatusCode.OK);
  }
}