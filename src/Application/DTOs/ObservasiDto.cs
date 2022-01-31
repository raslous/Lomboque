using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Lomboque.Application.DTOs
{
    public class ObservasiDto
    {
        [JsonPropertyName("suhu")] public float SuhuUdara { get; set; }
        [JsonPropertyName("kelembaban")] public List<int> KelembabanTanah { get; set; } = new();
    }
}