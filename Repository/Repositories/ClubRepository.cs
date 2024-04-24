using Microsoft.EntityFrameworkCore;
using Model.Entities;
using Model.Interfaces;
using Repository.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository.Repositories
{
    public class ClubRepository : Repository<Club>, IClubRepository
    {

        public ClubRepository(ApplicationDbContext dbContext) : base(dbContext)
        {
        }

        // Added override to include the players
        public override async Task<List<Club>> GetAll()
        {
            return await _dbSet.Include(x => x.Players).ToListAsync();
        }

        public override async Task<Club?> GetId(int id)
        {
            return await _dbSet.Include(x => x.Players).FirstOrDefaultAsync(x => x.Id == id);
        }
    }
}
