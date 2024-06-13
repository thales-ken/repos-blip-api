using System.Text.Json.Serialization;

namespace Domain.Entities;

public class Owner
{
    [JsonPropertyName("avatar_url")]
    public string? AvatarUrl { get; set; }
}