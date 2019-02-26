using DivisasBackofficeAPI.DatabaseContext;
using DivisasBackofficeAPI.Repositories;
using Microsoft.AspNetCore.Mvc;

namespace DivisasBackofficeAPI.Controllers
{
    public class CurrenciesController : ControllerBase
    {
        public CurrencyRepository Repository { get; set; }

        public CurrenciesController(CurrencyRepository repository)
        {
            Repository = repository;
        }



        
    }
}
