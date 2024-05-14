using Model.Entities;

namespace Model.Interfaces
{
    public interface IStandingRepository : IRepository<Standing>
    {
        Task<List<Standing>> GetAll();
        Task<Standing?> GetId(int id);
        Task<Standing?> GetStandingByClubId(int clubId);
        Task<List<Standing>> GetStandingsByTournament(int tournamentId);
        Task SaveChangesAsync();
    }
}