using Model.Entities;
using Model.Interfaces;
using Repository.Data;

namespace Repository.Repositories
{
    public class UnitOfWork : IDisposable
    {
        private readonly ApplicationDbContext _dbContext;

        //public IPlayerRepository Players { get; private set; } // quitamos referencia a la interfaz 
        
        public PlayerRepository Players { get; private set; } //pasamos a referencia a repository
        public ClubRepository Clubs { get; private set; }
        public MatchRepository Matches { get; private set; }
        public StandingRepository Standings { get; private set; }
        public TournamentRepository Tournaments { get; private set; }

        public UnitOfWork(ApplicationDbContext dbContext)
        {
            _dbContext = dbContext;
            Players = new PlayerRepository(dbContext);
            Clubs = new ClubRepository(dbContext);
            Matches = new MatchRepository(dbContext);           // new repository
            Standings = new StandingRepository(dbContext);         // new repository
            Tournaments = new TournamentRepository(dbContext);      // new repository
        }

        public async Task<int> SaveAsync()
        {
            return await _dbContext.SaveChangesAsync();
        }

        public void Dispose()
        {
            _dbContext?.Dispose();
        }

    }
}
