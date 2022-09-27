using CampaignsWithoutNumber.Server.Controllers;
using CampaignsWithoutNumber.Shared.DataTransferObjects;
using FluentAssertions;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Testing;

namespace CampaignsWithoutNumber.Server.UnitTests;

public sealed class WorldMapControllerTests
{
  [Fact]
  public async Task WorldMapController_ReturnsValidWorldMap()
  {
    var controller = new WorldMapController();
    var result = await controller.Get();
    result.Should().BeOfType<ActionResult<WorldMapDto>>();
    result.Value.Should().NotBeNull();
  }
}