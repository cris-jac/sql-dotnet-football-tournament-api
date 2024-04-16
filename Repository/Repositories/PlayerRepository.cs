using Microsoft.EntityFrameworkCore;
using Model.Entities;
using Model.Interfaces;
using Repository.Data;

namespace Repository.Repositories
{
    public class PlayerRepository : Repository<Player>, IPlayerRepository
    {
        public PlayerRepository(ApplicationDbContext dbContext) : base(dbContext)
        {
        }

        public async Task<Player?> GetPlayerByNumber(int playerNumber)
        {
            return await _dbSet.FirstOrDefaultAsync(x => x.Number == playerNumber);
        }
    }
}
