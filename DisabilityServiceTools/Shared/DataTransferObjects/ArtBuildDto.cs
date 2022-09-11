using System.Collections;
using System.Collections.Generic;

namespace CampaignsWithoutNumber.Shared.DataTransferObjects
{
	/// <summary>
	/// A list of <see cref="ArtDto"/>s selected by the character.
	/// </summary>
	public sealed class ArtBuildDto : IEnumerable<KeyValuePair<CharacterClassDto, IEnumerable<ArtDto>>>
	{
		private readonly Dictionary<CharacterClassDto, IEnumerable<ArtDto>> ArtsByClass;

		public ArtBuildDto()
		{
			ArtsByClass = new Dictionary<CharacterClassDto, IEnumerable<ArtDto>>();
		}
		
		public ArtBuildDto(Dictionary<CharacterClassDto, IEnumerable<ArtDto>> artSelections)
		{
			ArtsByClass = artSelections;
		}
		
		public IEnumerable<ArtDto> this[CharacterClassDto key]
		{
			get
			{
				if (!ArtsByClass.ContainsKey(key))
				{
					ArtsByClass.Add(key, new List<ArtDto>());
				}
				return ArtsByClass[key];
			}
			set => ArtsByClass[key] = value;
		}

		public IEnumerator<KeyValuePair<CharacterClassDto, IEnumerable<ArtDto>>> GetEnumerator()
		{
			return ArtsByClass.GetEnumerator();
		}

		IEnumerator IEnumerable.GetEnumerator()
		{
			return GetEnumerator();
		}
	}
}