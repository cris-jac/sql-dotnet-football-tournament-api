using Model.Entities;

namespace Model.Interfaces
{
    public interface IMatchRepository : IRepository<Match>
    {
        Task<List<Match>> GetAll();
        Task<Match?> GetId(int id);
        Task SaveChangesAsync();
    }
}