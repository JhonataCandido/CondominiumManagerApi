using CondominiumManagerApi.Core.Entities;
using CondominiumManagerApi.Core.Results;

namespace CondominiumManagerApi.Application.Services.CondominiumService
{
    public interface ICondominiumService
    {
        Task<Result<Condominium>> GetById(long id);
    }
}
