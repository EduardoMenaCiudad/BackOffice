using DivisasBackofficeAPI.DatabaseContext;
using DivisasBackofficeAPI.Repositories;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace DivisasBackofficeAPI.Controllers
{
    [Route("api/Currencies")]
    public class CurrenciesController : ControllerBase
    {
        public CurrencyRepository Repository { get; set; }

        public CurrenciesController(CurrencyRepository repository)
        {
            Repository = repository;
        }

        [HttpGet]
        public async Task<IActionResult> Get()
        {
            Repository.
        }
        
    }
}
