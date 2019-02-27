using DivisasBackofficeAPI.DatabaseContext;
using DivisasBackofficeAPI.Entities;
using DivisasBackofficeAPI.Filters;
using DivisasBackofficeAPI.Repositories;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace DivisasBackofficeAPI.Controllers

{   [ServiceFilter(typeof(LogActionFilter))]
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
