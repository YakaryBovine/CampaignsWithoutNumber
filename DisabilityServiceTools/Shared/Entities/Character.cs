﻿using System.Collections.Generic;
using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace CampaignsWithoutNumber.Shared.Entities
{
	public sealed class Character
	{
		[BsonRepresentation(BsonType.ObjectId)]
		public string? Id { get; set; }

		public string? Name { get; set; }

		public List<ICharacterClass>? CharacterClasses { get; set; }

		public int Level { get; set; }
		
		/// <summary>
		/// Attributes which determine the core statistics of the character.
		/// </summary>
		public IEnumerable<IAttribute>? Attributes { get; set; }
	}
}