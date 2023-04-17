
using FurkanMaps.Model;
using Microsoft.EntityFrameworkCore;


namespace FurkanMaps
{
    public class context : DbContext
    {       
        public DbSet<MyForecastData> tblForecastWeatherData { get; set; }
        public DbSet<MyHistoricData> tblHistoricWeatherData { get; set; }
        public DbSet<clsAna> anaSet { get; set; }
        public DbSet<clsSehir> tblSehir { get; set; }



        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
            => optionsBuilder.UseNpgsql("Host=localhost;Database=CeliklerDb;Username=postgres;Password=Fc123456*");

      
    }
}
