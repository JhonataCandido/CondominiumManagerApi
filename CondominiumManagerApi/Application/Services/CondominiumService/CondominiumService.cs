using CondominiumManagerApi.Core.Entities;
using CondominiumManagerApi.Core.Results;
using CondominiumManagerApi.Infrastructure.SqlServer.Repositories.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace CondominiumManagerApi.Application.Services.CondominiumService
{
    public class CondominiumService(ICondominiumRepository condominiumRepository) : ICondominiumService
    {
        public async Task<Result<Condominium>> GetById(long id)
        { 
            var condominium = await condominiumRepository.GetById(id);

            if (condominium is null)
                return Result<Condominium>.Failure("Condomínio não encontrado!");

            return Result<Condominium>.Success(condominium);
        }
    }
}