using CondominiumManagerApi.Application.Services.CondominiumService;
using CondominiumManagerApi.Core.Entities;
using CondominiumManagerApi.Core.Results;
using Microsoft.AspNetCore.Mvc;

namespace CondominiumManagerApi.WebApi.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class CondominiumController(ICondominiumService condominiumService) : ControllerBase
    {
        [HttpGet("{id}")]
        public async Task<Result<Condominium>> Get([FromRoute] long id)
        {
            return await condominiumService.GetById(id);
        }
    }
}