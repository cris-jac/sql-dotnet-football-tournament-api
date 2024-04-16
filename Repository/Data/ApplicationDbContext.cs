using Microsoft.EntityFrameworkCore;
using Model.Entities;

namespace Repository.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions options) : base(options)
        {

        }
        public DbSet<Player> Players { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Player>().HasData(
                new Player { Id = 1, Name = "Lionel", Surname = "Messi", DateOfBirth = new DateTime(1987, 06, 24), DocumentType = "DNI", DocumentNumber = 12345678, Number = 10, Position = "Delantero", Starter = true },
                new Player { Id = 2, Name = "Emiliano", Surname = "Martinez", DateOfBirth = new DateTime(1992, 09, 02), DocumentType = "DNI", DocumentNumber = 98765432, Number = 23, Position = "Arquero", Starter = false },
                new Player { Id = 3, Name = "Enzo", Surname = "Fernandez", DateOfBirth = new DateTime(2001, 01, 17), DocumentType = "DNI", DocumentNumber = 13572468, Number = 24, Position = "Mediocampista", Starter = true },
                new Player { Id = 4, Name = "Gonzalo", Surname = "Montiel", DateOfBirth = new DateTime(1997, 01, 01), DocumentType = "DNI", DocumentNumber = 97532468, Number = 4, Position = "Defensor", Starter = true }
            );
        }
    }
}
