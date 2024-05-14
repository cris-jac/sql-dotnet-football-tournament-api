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
    public class MatchRepository : Repository<Match>, IMatchRepository
    {
        public MatchRepository(ApplicationDbContext dbContext) : base(dbContext)
        {

        }

        public override async Task<List<Match>> GetAll()
        {
            return await _dbSet.Include(x => x.Tournament).Include(x => x.Club1).Include(x => x.Club2).Include(x => x.Stadium).Include(x => x.Winner).ToListAsync();
        }

        public override async Task<Match?> GetId(int id)
        {
            return await _dbSet.Include(x => x.Tournament).Include(x => x.Club1).Include(x => x.Club2).Include(x => x.Stadium).Include(x => x.Winner).FirstOrDefaultAsync(x => x.Id == id);
        }

        public async Task SaveChangesAsync()
        {
            await _dbContext.SaveChangesAsync();
        }

    }
}
