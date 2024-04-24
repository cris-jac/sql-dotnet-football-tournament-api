using Microsoft.EntityFrameworkCore;
using Model.Entities;

namespace Repository.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {

        }
        public DbSet<Player> Players { get; set; }
        public DbSet<Club> Club { get; set; }
        public DbSet<Stadium> Stadium { get; set; }
        public DbSet<Match> Matches { get; set; }
        public DbSet<Standing> Standings { get; set; }
        public DbSet<Tournament> Tournaments { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Player>().HasData(
                new Player { Id = 1, Name = "Franco", Surname = "Armani", DateOfBirth = new DateTime(1986, 10, 16), DocumentType = "DNI", DocumentNumber = 12345678, Number = 1, Position = "Arquero", Starter = true, ClubId = 1 },
                new Player { Id = 2, Name = "Gonzalo", Surname = "Montiel", DateOfBirth = new DateTime(1996, 01, 01), DocumentType = "DNI", DocumentNumber = 23456789, Number = 4, Position = "Defensor", Starter = true, ClubId = 1 },
                new Player { Id = 3, Name = "Javier", Surname = "Pinola", DateOfBirth = new DateTime(1983, 02, 24), DocumentType = "DNI", DocumentNumber = 34567890, Number = 22, Position = "Defensor", Starter = true, ClubId = 1 },
                new Player { Id = 4, Name = "Lucas", Surname = "Martínez Quarta", DateOfBirth = new DateTime(1996, 05, 10), DocumentType = "DNI", DocumentNumber = 45678901, Number = 29, Position = "Defensor", Starter = true, ClubId = 1 },
                new Player { Id = 5, Name = "Milton", Surname = "Casco", DateOfBirth = new DateTime(1988, 04, 11), DocumentType = "DNI", DocumentNumber = 56789012, Number = 20, Position = "Defensor", Starter = true, ClubId = 1 },
                new Player { Id = 6, Name = "Exequiel", Surname = "Palacios", DateOfBirth = new DateTime(1998, 10, 05), DocumentType = "DNI", DocumentNumber = 67890123, Number = 15, Position = "Centrocampista", Starter = true, ClubId = 1 },
                new Player { Id = 7, Name = "Leonardo", Surname = "Ponzio", DateOfBirth = new DateTime(1982, 01, 29), DocumentType = "DNI", DocumentNumber = 78901234, Number = 23, Position = "Centrocampista", Starter = true, ClubId = 1 },
                new Player { Id = 8, Name = "Ignacio", Surname = "Fernández", DateOfBirth = new DateTime(1990, 01, 12), DocumentType = "DNI", DocumentNumber = 89012345, Number = 26, Position = "Centrocampista", Starter = true, ClubId = 1 },
                new Player { Id = 9, Name = "Rafael", Surname = "Santos Borré", DateOfBirth = new DateTime(1995, 09, 15), DocumentType = "DNI", DocumentNumber = 90123456, Number = 19, Position = "Delantero", Starter = true, ClubId = 1 },
                new Player { Id = 10, Name = "Lucas", Surname = "Pratto", DateOfBirth = new DateTime(1988, 06, 04), DocumentType = "DNI", DocumentNumber = 01234567, Number = 27, Position = "Delantero", Starter = true, ClubId = 1 },
                new Player { Id = 11, Name = "Juan Fernando", Surname = "Quintero", DateOfBirth = new DateTime(1993, 01, 18), DocumentType = "DNI", DocumentNumber = 12345678, Number = 8, Position = "Centrocampista", Starter = true, ClubId = 1 },
                new Player { Id = 12, Name = "Agustín", Surname = "Rossi", DateOfBirth = new DateTime(1995, 08, 21), DocumentType = "DNI", DocumentNumber = 12345678, Number = 1, Position = "Arquero", Starter = true, ClubId = 2 },
                new Player { Id = 13, Name = "Leonardo", Surname = "Jara", DateOfBirth = new DateTime(1991, 05, 20), DocumentType = "DNI", DocumentNumber = 23456789, Number = 29, Position = "Defensor", Starter = true, ClubId = 2 },
                new Player { Id = 14, Name = "Carlos", Surname = "Izquierdoz", DateOfBirth = new DateTime(1989, 03, 19), DocumentType = "DNI", DocumentNumber = 34567890, Number = 24, Position = "Defensor", Starter = true, ClubId = 2 },
                new Player { Id = 15, Name = "Lisandro", Surname = "Magallán", DateOfBirth = new DateTime(1993, 09, 27), DocumentType = "DNI", DocumentNumber = 45678901, Number = 6, Position = "Defensor", Starter = true, ClubId = 2 },
                new Player { Id = 16, Name = "Emmanuel", Surname = "Mas", DateOfBirth = new DateTime(1989, 10, 15), DocumentType = "DNI", DocumentNumber = 56789012, Number = 3, Position = "Defensor", Starter = true, ClubId = 2 },
                new Player { Id = 17, Name = "Nahitan", Surname = "Nández", DateOfBirth = new DateTime(1995, 12, 28), DocumentType = "DNI", DocumentNumber = 67890123, Number = 15, Position = "Centrocampista", Starter = true, ClubId = 2 },
                new Player { Id = 18, Name = "Wilmar", Surname = "Barrios", DateOfBirth = new DateTime(1993, 10, 16), DocumentType = "DNI", DocumentNumber = 78901234, Number = 16, Position = "Centrocampista", Starter = true, ClubId = 2 },
                new Player { Id = 19, Name = "Pablo", Surname = "Pérez", DateOfBirth = new DateTime(1985, 02, 10), DocumentType = "DNI", DocumentNumber = 89012345, Number = 8, Position = "Centrocampista", Starter = true, ClubId = 2 },
                new Player { Id = 20, Name = "Cristian", Surname = "Pavón", DateOfBirth = new DateTime(1996, 01, 21), DocumentType = "DNI", DocumentNumber = 90123456, Number = 7, Position = "Delantero", Starter = true, ClubId = 2 },
                new Player { Id = 21, Name = "Ramón", Surname = "Ábila", DateOfBirth = new DateTime(1989, 10, 14), DocumentType = "DNI", DocumentNumber = 01234567, Number = 9, Position = "Delantero", Starter = true, ClubId = 2 },
                new Player { Id = 22, Name = "Darío", Surname = "Benedetto", DateOfBirth = new DateTime(1990, 05, 17), DocumentType = "DNI", DocumentNumber = 12345678, Number = 9, Position = "Delantero", Starter = true, ClubId = 2 },
                new Player { Id = 23, Name = "Martín", Surname = "Campaña", DateOfBirth = new DateTime(1989, 05, 29), DocumentType = "DNI", DocumentNumber = 12345678, Number = 1, Position = "Arquero", Starter = true, ClubId = 3 },
                new Player { Id = 24, Name = "Alan", Surname = "Franco", DateOfBirth = new DateTime(1996, 05, 11), DocumentType = "DNI", DocumentNumber = 23456789, Number = 2, Position = "Defensor", Starter = true, ClubId = 3 },
                new Player { Id = 25, Name = "Nicolás", Surname = "Tagliafico", DateOfBirth = new DateTime(1992, 08, 31), DocumentType = "DNI", DocumentNumber = 34567890, Number = 3, Position = "Defensor", Starter = true, ClubId = 3 },
                new Player { Id = 26, Name = "Gastón", Surname = "Silva", DateOfBirth = new DateTime(1994, 03, 05), DocumentType = "DNI", DocumentNumber = 45678901, Number = 4, Position = "Defensor", Starter = true, ClubId = 3 },
                new Player { Id = 27, Name = "Fabricio", Surname = "Bustos", DateOfBirth = new DateTime(1996, 04, 28), DocumentType = "DNI", DocumentNumber = 56789012, Number = 16, Position = "Defensor", Starter = true, ClubId = 3 },
                new Player { Id = 28, Name = "Pablo", Surname = "Hernández", DateOfBirth = new DateTime(1986, 04, 23), DocumentType = "DNI", DocumentNumber = 67890123, Number = 10, Position = "Centrocampista", Starter = true, ClubId = 3 },
                new Player { Id = 29, Name = "Maximiliano", Surname = "Meza", DateOfBirth = new DateTime(1992, 12, 15), DocumentType = "DNI", DocumentNumber = 78901234, Number = 11, Position = "Centrocampista", Starter = true, ClubId = 3 },
                new Player { Id = 30, Name = "Ezequiel", Surname = "Barco", DateOfBirth = new DateTime(1999, 03, 29), DocumentType = "DNI", DocumentNumber = 89012345, Number = 20, Position = "Centrocampista", Starter = true, ClubId = 3 },
                new Player { Id = 31, Name = "Emmanuel", Surname = "Gigliotti", DateOfBirth = new DateTime(1987, 05, 10), DocumentType = "DNI", DocumentNumber = 90123456, Number = 9, Position = "Delantero", Starter = true, ClubId = 3 },
                new Player { Id = 32, Name = "Fernando", Surname = "Gaibor", DateOfBirth = new DateTime(1991, 11, 08), DocumentType = "DNI", DocumentNumber = 01234567, Number = 15, Position = "Centrocampista", Starter = true, ClubId = 3 },
                new Player { Id = 33, Name = "Martín", Surname = "Benítez", DateOfBirth = new DateTime(1994, 09, 05), DocumentType = "DNI", DocumentNumber = 12345678, Number = 8, Position = "Centrocampista", Starter = true, ClubId = 3 },
                new Player { Id = 34, Name = "Martín", Surname = "Campaña", DateOfBirth = new DateTime(1989, 05, 29), DocumentType = "DNI", DocumentNumber = 12345678, Number = 1, Position = "Arquero", Starter = true, ClubId = 3 },
                new Player { Id = 35, Name = "Alan", Surname = "Franco", DateOfBirth = new DateTime(1996, 05, 11), DocumentType = "DNI", DocumentNumber = 23456789, Number = 2, Position = "Defensor", Starter = true, ClubId = 3 },
                new Player { Id = 36, Name = "Nicolás", Surname = "Tagliafico", DateOfBirth = new DateTime(1992, 08, 31), DocumentType = "DNI", DocumentNumber = 34567890, Number = 3, Position = "Defensor", Starter = true, ClubId = 3 },
                new Player { Id = 37, Name = "Gastón", Surname = "Silva", DateOfBirth = new DateTime(1994, 03, 05), DocumentType = "DNI", DocumentNumber = 45678901, Number = 4, Position = "Defensor", Starter = true, ClubId = 3 },
                new Player { Id = 38, Name = "Fabricio", Surname = "Bustos", DateOfBirth = new DateTime(1996, 04, 28), DocumentType = "DNI", DocumentNumber = 56789012, Number = 16, Position = "Defensor", Starter = true, ClubId = 3 },
                new Player { Id = 39, Name = "Pablo", Surname = "Hernández", DateOfBirth = new DateTime(1986, 04, 23), DocumentType = "DNI", DocumentNumber = 67890123, Number = 10, Position = "Centrocampista", Starter = true, ClubId = 3 },
                new Player { Id = 40, Name = "Maximiliano", Surname = "Meza", DateOfBirth = new DateTime(1992, 12, 15), DocumentType = "DNI", DocumentNumber = 78901234, Number = 11, Position = "Centrocampista", Starter = true, ClubId = 3 },
                new Player { Id = 41, Name = "Ezequiel", Surname = "Barco", DateOfBirth = new DateTime(1999, 03, 29), DocumentType = "DNI", DocumentNumber = 89012345, Number = 20, Position = "Centrocampista", Starter = true, ClubId = 3 },
                new Player { Id = 42, Name = "Emmanuel", Surname = "Gigliotti", DateOfBirth = new DateTime(1987, 05, 10), DocumentType = "DNI", DocumentNumber = 90123456, Number = 9, Position = "Delantero", Starter = true, ClubId = 3 },
                new Player { Id = 43, Name = "Fernando", Surname = "Gaibor", DateOfBirth = new DateTime(1991, 11, 08), DocumentType = "DNI", DocumentNumber = 01234567, Number = 15, Position = "Centrocampista", Starter = true, ClubId = 3 },
                new Player { Id = 44, Name = "Martín", Surname = "Benítez", DateOfBirth = new DateTime(1994, 09, 05), DocumentType = "DNI", DocumentNumber = 12345678, Number = 8, Position = "Centrocampista", Starter = true, ClubId = 3 }

            );

            modelBuilder.Entity<Club>().HasData(
                new Club { Id = 1, Name = "River Plate", FoundationDate = new DateTime(1901, 05, 25), Manager = "Marcelo Gallardo" },
                new Club { Id = 2, Name = "Boca Juniors", FoundationDate = new DateTime(1905, 04, 03), Manager = "Miguel Ángel Russo" },
                new Club { Id = 3, Name = "Independiente", FoundationDate = new DateTime(1905, 03, 01), Manager = "Julio Falcioni" },
                new Club { Id = 4, Name = "Racing", FoundationDate = new DateTime(1905, 03, 01), Manager = "Eduardo Coudet" }
            );

            modelBuilder.Entity<Stadium>().HasData(
                new Stadium { Id = 1, Name = "Monumental", Location = "Buenos Aires", Capacity = 86000, ClubId = 1 },
                new Stadium { Id = 2, Name = "La Bombonera", Location = "Buenos Aires", Capacity = 57000, ClubId = 2 }, // Boca Juniors
                new Stadium { Id = 3, Name = "Libertadores de América", Location = "Avellaneda", Capacity = 48000, ClubId = 3 }, // Independiente
                new Stadium { Id = 4, Name = "Presidente Perón", Location = "Avellaneda", Capacity = 53000, ClubId = 4 }
            );

            

        }
    }
}
