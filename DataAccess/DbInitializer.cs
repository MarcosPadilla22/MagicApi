using DataAccess.Models;
using Microsoft.EntityFrameworkCore;

namespace DataAccess
{
    public class DbInitializer
    {
        private readonly ModelBuilder modelBuilder;

        public DbInitializer(ModelBuilder modelBuilder)
        {
            this.modelBuilder = modelBuilder;
        }

        public void Seed()
        {
            modelBuilder.Entity<Grimoire>().HasData(
                   new Grimoire() { Id = 1, Name = "Sinceridad", Description = "Trébol de 1 hoja" },
                   new Grimoire() { Id = 2, Name = "Esperanza", Description = "Trébol de 2 hojas" },
                   new Grimoire() { Id = 3, Name = "Amor", Description = "Trébol de 3 hojas" },
                   new Grimoire() { Id = 4, Name = "Buena Fortuna", Description = "Trébol de 4 hojas" },
                   new Grimoire() { Id = 5, Name = "Desesperación", Description = "Trébol de 5 hojas" }
            );

            modelBuilder.Entity<Affinity>().HasData(
                   new Affinity() { Id = 1, Name = "Oscuridad", Description = "" },
                   new Affinity() { Id = 2, Name = "Luz", Description = "" },
                   new Affinity() { Id = 3, Name = "Fuego", Description = "" },
                   new Affinity() { Id = 4, Name = "Agua", Description = "" },
                   new Affinity() { Id = 5, Name = "Viento", Description = "" },
                   new Affinity() { Id = 6, Name = "Tierra", Description = "" }
             );
        }
    }
}
