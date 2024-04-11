using LaboratorioAws.Data;
using LaboratorioAws.Entities;
using Repository.interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository
{
    internal class PlayerRepository : Repository<Player>, IPlayerRepository
    {
        public PlayerRepository(DataContext context) : base(context) 
        { 

        }

        //aca habria que agregar los metodos que agreguemos en la interfaz del player
    }
}
