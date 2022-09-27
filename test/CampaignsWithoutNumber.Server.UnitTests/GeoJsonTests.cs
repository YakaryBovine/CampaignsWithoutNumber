using System.Text.Json;
using FluentAssertions;
using GeoJSON.Text.Feature;

namespace CampaignsWithoutNumber.Server.UnitTests;

public sealed class GeoJsonTests
{
  [Theory]
  [InlineData("markers.geojson")]
  [InlineData("map.geojson")]
  public void JsonSerializer_Deserialize_CanDeserializeStates(string filePath)
  {
    var text = File.ReadAllText(filePath);
    var featureCollection = JsonSerializer.Deserialize<FeatureCollection>(text);
    featureCollection.Should().NotBeNull();
    featureCollection?.Features.Count.Should().NotBe(0);
  }
}