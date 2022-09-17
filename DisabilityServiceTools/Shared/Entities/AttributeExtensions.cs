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
        < 3 => throw new ArgumentException("Attribute modifiers cannot be given for attribute values less than 3.",
          nameof(attribute)),
        > 18 => throw new ArgumentException("Attribute modifiers cannot be given for attribute values greater than 18.",
          nameof(attribute)),
        _ => AttributeModifiers[value-1]
      };
    }
  }
}