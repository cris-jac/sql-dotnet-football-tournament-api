using Model.Entities;

namespace Model.Interfaces
{
    public interface IPlayerRepository : IRepository<Player>
    {
        Task<Player?> GetPlayerByNumber(int playerNumber);
    }
}
