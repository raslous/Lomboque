using System.Text.Json;
using Lomboque.Domain.Entities;
using Lomboque.Application.Common.Interfaces;
using Lomboque.Application.DTOs;

namespace Lomboque.Application.Actions
{
    public class AppController
    {
        private readonly IApplicationDbContext applicationDbContext;

        public AppController(IApplicationDbContext applicationDbContext)
        {
            this.applicationDbContext = applicationDbContext;
        }

        public async Task InsertObservasiAsync(string json)
        {
            ObservasiDto observasiDto  = JsonSerializer
                .Deserialize<ObservasiDto>(json)!;

            List<Observasi> hasilObservasi = AutoMapper(observasiDto);
            
            foreach (var pot in hasilObservasi)
            {
                applicationDbContext.Observasi.Add(pot);    
            }

            await applicationDbContext.SaveChangesAsync();

        }

        public List<Observasi> AutoMapper(ObservasiDto observasiDto)
        {
            List<Observasi> daftarObservasi = new();

            for (int i = 0; i < observasiDto.KelembabanTanah.Count; i++)
            {
                Observasi pot = new Observasi{
                    SuhuUdara = observasiDto.SuhuUdara,
                    KelembabanTanah = observasiDto.KelembabanTanah[i]
                };

                daftarObservasi.Add(pot);
            }

            return daftarObservasi;
        }
    }
}