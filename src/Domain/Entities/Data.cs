using System.Collections.Generic;

namespace Lomboque.Domain.Entities
{
    public class Data
    {
        public int Id { get; set; }
        public float Temperature { get; set; }
        public List<float> Humidity { get; set; } = new();

    }
}