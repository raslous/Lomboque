using System.Collections.Generic;
using Lomboque.Domain.Entities;

namespace Lomboque.Domain.Entities
{
    public class Observasi
    {
        public int Id { get; set; }
        public DateOnly Tanggal { get; set; } = new DateOnly(
            DateTime.Now.Year, 
            DateTime.Now.Month,
            DateTime.Now.Day
        );
        public TimeOnly Jam { get; set; } = new TimeOnly(
            DateTime.Now.Hour,
            DateTime.Now.Minute,
            DateTime.Now.Second
        );

        public List<Pot>? LarikPot { get; set; }

    }
}