using Model.Entities;
using Repository.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository.Repositories
{
    public class TournamentRepository : Repository<Tournament>
    {
        public TournamentRepository(ApplicationDbContext dbContext) : base(dbContext)
        {
            
        }

    }
}
