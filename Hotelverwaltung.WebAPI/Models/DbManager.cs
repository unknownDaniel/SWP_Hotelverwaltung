using Hotelverwaltung.Models;
using Microsoft.EntityFrameworkCore;

namespace Hotelverwaltung.WebAPI.Models
{
    public class DbManager : DbContext
    {
        public DbSet<Room> Rooms { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            // für den Pomelo-MySQL-Treiber
            string connectionString = "Server=localhost;database=hotelverwaltung_4bhwii;user=root;password=dani99dani";
            optionsBuilder.UseMySql(connectionString, ServerVersion.AutoDetect(connectionString));
        }
    }
}
