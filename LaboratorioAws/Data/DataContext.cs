using LaboratorioAws.Entities;
using Microsoft.EntityFrameworkCore;

namespace LaboratorioAws.Data
{
    public class DataContext : DbContext
    {

        public DataContext(DbContextOptions options) : base(options)
        {

        }
        public DbSet<Player> Players { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Player>().HasData(
                new Player { Id = 1, Name = "Lionel 1", Surname = "Messi 1", DateOfBirth = new DateTime(1987, 06, 24), DocumentType = "DNI", DocumentNumber = 12345678, Number = 10, Position = "Delantero", Starter = true },
                new Player { Id = 2, Name = "Lionel 2", Surname = "Messi 2", DateOfBirth = new DateTime(1977, 05, 23), DocumentType = "DNI", DocumentNumber = 98765432, Number = 10, Position = "Arquero", Starter = false },
                new Player { Id = 3, Name = "Lionel 3", Surname = "Messi 3", DateOfBirth = new DateTime(1997, 07, 25), DocumentType = "DNI", DocumentNumber = 13572468, Number = 11, Position = "Mediocampista", Starter = true }
            );
        }
    }
}
