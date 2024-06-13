using Newtonsoft.Json;
using System.Text.Json.Serialization;

namespace Domain.Entities;

public class GithubResponse
{
    [JsonProperty("full_name")]
    public string? FullName { get; set; }

    [JsonProperty("description")]
    public string? Description { get; set; }

    [JsonProperty("created_at")]
    public string? CreatedAt { get; set; }

    [JsonProperty("language")]
    public string Language { get; set; }

    [JsonProperty("owner")]
    public Owner Owner { get; set; }
}
