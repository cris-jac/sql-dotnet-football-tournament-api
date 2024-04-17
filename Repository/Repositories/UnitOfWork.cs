using Model.Interfaces;
using Repository.Data;

namespace Repository.Repositories
{
    public class UnitOfWork : IDisposable
    {
        private readonly ApplicationDbContext _dbContext;

        //public IPlayerRepository Players { get; private set; } // quitamos referencia a la interfaz
        public PlayerRepository Players { get; private set; }

        public UnitOfWork(ApplicationDbContext dbContext)
        {
            _dbContext = dbContext;
            Players = new PlayerRepository(dbContext);
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
