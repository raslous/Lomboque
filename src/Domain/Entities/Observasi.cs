namespace Lomboque.Domain.Entities
{
    public class Observasi
    {
        public int Id { get; set; }
        public int NomorPot { get; set; }
        public float SuhuUdara { get; set; }
        public int KelembabanTanah { get; set; }
        public DateOnly Tanggal { get; set; } = new DateOnly(
            DateTime.Now.Year, 
            DateTime.Now.Month,
            DateTime.Now.Day - 5
        );
        public TimeOnly Jam { get; set; } = new TimeOnly(
            DateTime.Now.Hour,
            DateTime.Now.Minute,
            DateTime.Now.Second
        );

 

    }
}