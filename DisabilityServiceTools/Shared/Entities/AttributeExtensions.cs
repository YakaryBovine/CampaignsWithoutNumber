using System;

namespace CampaignsWithoutNumber.Shared.Entities
{
  public static class AttributeExtensions
  {
    private static readonly int[] AttributeModifiers = {-2, -2, -2, -1, -1, -1, -1, 0, 0, 0, 0, 0, 0, 1, 1, 1, 1, 2};

    public static int CalculateModifier(this IAttribute attribute)
    {
      var value = attribute.Value;
      return value switch
      {
        < 3 => AttributeModifiers[0],
        > 18 => AttributeModifiers[^1],
        _ => AttributeModifiers[value - 1]
      };
    }
  }
}