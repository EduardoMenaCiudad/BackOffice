using DivisasBackofficeAPI.DatabaseContext;
using DivisasBackofficeAPI.Entities;
using DivisasBackofficeAPI.Repositories;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace DivisasBackofficeAPI.Controllers
{
    [Route("api/Currencies")]
    public class CurrenciesController : ControllerBase
    {
        public IRepository<Currency> Repository { get; set; }

        public CurrenciesController(IRepository<Currency> repository)
        {
            Repository = repository;
        }

        [HttpGet]
        public async Task<IActionResult> Get()
        {
            var result = await Repository.Get();

            return Ok(result);
        }
        
    }
}
