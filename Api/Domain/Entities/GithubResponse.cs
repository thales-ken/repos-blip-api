using System.Text.Json.Serialization;

namespace Domain.Entities;

public class GithubResponse
{
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    [JsonPropertyName("description")]
    public string? Description { get; set; }

    [JsonPropertyName("owner")]
    public Owner? Owner { get; set; }
}
