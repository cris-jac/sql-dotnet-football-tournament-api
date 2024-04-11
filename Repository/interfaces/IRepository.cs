using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository.interfaces
{
    public interface IRepository<T> where T : class
    {
        Task<List<T>> GetAll();
        Task<T> GetId(int id);
        Task Add(T entity);
        void Delete(T entity);
        void Edit(T entity);
    }
}
