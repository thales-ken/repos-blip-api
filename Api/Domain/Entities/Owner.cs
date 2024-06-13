using Newtonsoft.Json;
using System.Text.Json.Serialization;

namespace Domain.Entities;

public class Owner
{
    [JsonProperty("avatar_url")]
    public string? AvatarUrl { get; set; }
}