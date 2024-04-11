using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository.interfaces
{
    public interface IUnitOfWork : IDisposable
    {
        public IPlayerRepository PlayerRepository { get; }
        Task<int> Save();
    }
}
