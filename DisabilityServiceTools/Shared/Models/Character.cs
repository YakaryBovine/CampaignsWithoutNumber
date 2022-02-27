﻿using System.Collections.Generic;
using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace CampaignsWithoutNumber.Shared.Models
{
  public sealed class Character
  {
    [BsonRepresentation(BsonType.ObjectId)]
    public string Id { get; set; }
    
    public string Name { get; set; }

    public CharacterClass CharacterClass { get; set; }

    public int Level { get; set; }

    public List<Item> Items { get; } = new();
  }
}