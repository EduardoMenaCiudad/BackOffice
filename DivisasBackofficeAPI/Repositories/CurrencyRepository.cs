using DivisasBackofficeAPI.DatabaseContext;
using DivisasBackofficeAPI.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DivisasBackofficeAPI.Repositories
{
    public class CurrencyRepository : IRepository<Currency>
    {
        public DivisasContext Context { get; set; }

        public CurrencyRepository(DivisasContext context)
        {
            Context = context;
        }

        public Task Create(Currency toCreate)
        {
            throw new NotImplementedException();
        }

        public Task Delete(int id)
        {
            throw new NotImplementedException();
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

        public void Dispose(bool disposing)
        {
            if (disposing)
            {
                if(this.Context != null)
                {
                    this.Context.Dispose();
                    this.Context = null; 
                }
            }
        }

        public Task<IEnumerable<Currency>> Get()
        {
            throw new NotImplementedException();
        }

        public Task<Currency> Get(int id)
        {
            throw new NotImplementedException();
        }

        public Task SaveChangesAsync()
        {
            throw new NotImplementedException();
        }

        public Task Update(Currency toUpdate)
        {
            throw new NotImplementedException();
        }
    }
}
