

namespace Model.Interfaces
{
    public interface IUnitOfWork : IDisposable
    {
        // public IPlayerRepository Players { get; }
        // public PlayerRepository Players { get; }        // Generates circular dependency
        //Task<int> SaveAsync();
    }
}
