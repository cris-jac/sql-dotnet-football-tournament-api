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
    }
}
