using Microsoft.EntityFrameworkCore;
using Model.Entities;
using Repository.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository.Repositories
{
    public class StandingRepository : Repository<Standing>
    {
        public StandingRepository(ApplicationDbContext dbContext) : base(dbContext)
        {

        }

        public override async Task<List<Standing>> GetAll()
        {
            return await _dbSet.Include(x => x.Tournament).Include(x => x.Club).ToListAsync();
        }

        public async Task<Standing?> GetStandingByClubId(int clubId)
        {
            return await _dbSet.Include(x => x.Tournament).Include(x => x.Club).FirstOrDefaultAsync(x => x.ClubId == clubId);
        }

        public async Task<List<Standing>> GetStandingsByTournament(int tournamentId)
        {
            return await _dbSet.Include(x => x.Tournament).Include(x => x.Club).Where(x => x.TournamentId == tournamentId).ToListAsync();
        }

        public override async Task<Standing?> GetId(int id)
        {
            return await _dbSet.Include(x => x.Tournament).Include(x => x.Club).FirstOrDefaultAsync(x => x.Id == id);
        }
    }
}
