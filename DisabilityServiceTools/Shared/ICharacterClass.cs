using System.Collections.Generic;
using CampaignsWithoutNumber.Shared.DataTransferObjects;
using CampaignsWithoutNumber.Shared.Entities;

namespace CampaignsWithoutNumber.Shared
{
	public interface ICharacterClass
	{
    /// <summary>
    ///    A user-friendly name for the class.
    /// </summary>
    public string Name { get; }

    /// <summary>
    ///    How much attack bonus per level this class gives.
    ///    Only the highest value of any class is respected.
    /// </summary>
    public float AttackBonusPerLevel { get; }

    /// <summary>
    ///    How many hit points per level this class gives.
    ///    Only the highest value of any class is respected.
    /// </summary>
    public float HitPointsPerLevel { get; }

		public List<CharacterFeature> Features { get; }

    /// <summary>
    ///    Class-specific Arts that a player can select if they have this class.
    /// </summary>
    public List<IArt> Arts { get; }

    /// <summary>
    ///    Unique identifier.
    /// </summary>
    public int Id { get; }

		public void Apply(CharacterDto characterDto)
		{
			characterDto.HitPoints = (int) (HitPointsPerLevel * characterDto.Level);
			characterDto.AttackBonus = (int) (AttackBonusPerLevel * characterDto.Level);
			foreach (var feature in Features) feature.Apply(characterDto);
		}
	}
}