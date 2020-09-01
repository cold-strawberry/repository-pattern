using Newtonsoft.Json;
using System;
using System.ComponentModel.DataAnnotations.Schema;
namespace Premium.DatabaseAdapters.postgresql.models
{
    [Table("platform")]
    public class Platform
    {
        [JsonProperty("id")]
        public int Id { get; private set; }

        [JsonProperty("name")]
        public string Name { get; private set; }

        [JsonProperty("description")]
        public string Description { get; private set; }

        [JsonProperty("platformtype")]
        public string PlatformType { get; private set; }

        [JsonConstructor]
        public Platform(int id, string name, string description, string platformType)
        {
            Id = id;
            Name = name;
            Description = description;
            PlatformType = platformType;
        }
    }
}