using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Lomboque.Application.DTOs
{
    public class DataDto
    {
        [JsonPropertyName("temperature")] public float Temperature { get; set; }
        [JsonPropertyName("humidities")] public List<int>? Humidities { get; set; } = new();
    }
}