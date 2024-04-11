using LaboratorioAws.Data; //porque no me reconoce esto? no puedo tener dos referencias al mismo tiempo?
using Repository.interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository
{
    public class UnitOfWork : IUnitOfWork //si lo dejo en private no lo puedo acceder con el controller
    {
        public IPlayerRepository PlayerRepository { get; }

        private readonly DataContext _context;
        public UnitOfWork(DataContext context, IPlayerRepository playerRepository)
        {
            _context = context;
            PlayerRepository = playerRepository;
        }

        public async Task<int> Save()
        {
            return await _context.SaveChangesAsync();
        }

        public void Dispose()
        {
            _context?.Dispose();
        }

    }
}
