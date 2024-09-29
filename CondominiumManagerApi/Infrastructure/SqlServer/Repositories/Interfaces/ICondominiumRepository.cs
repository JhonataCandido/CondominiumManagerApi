using CondominiumManagerApi.Core.Entities;

namespace CondominiumManagerApi.Infrastructure.SqlServer.Repositories.Interfaces
{
    public interface ICondominiumRepository
    {
        Task<Condominium> GetById(long id);
    }
}
