// using Lomboque.Domain.Entities;
using Lomboque.Application.DTOs;
using System.Text.Json;

namespace Lomboque.Application.Actions
{
    public class DataController
    {
        public string CreateData()
        {
            var dataDto = new DataDto();
            dataDto.Temperature = 34;
            dataDto.Humidities!.Add(90);
            dataDto.Humidities!.Add(87);

            string dataJson = JsonSerializer.Serialize<DataDto>(dataDto);

            return dataJson;
        }

        public void SerializeData(string json)
        {
            try
            {
                DataDto data = JsonSerializer.Deserialize<DataDto>(json)!;
                System.Console.WriteLine($"t: {data!.Temperature}");
                System.Console.WriteLine($"h total: {data.Humidities!.Count}");

            }
            catch (System.Exception)
            {
                
                throw;
            }
        }
    }
}