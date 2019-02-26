using DivisasBackofficeAPI.DatabaseContext;
using DivisasBackofficeAPI.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace DivisasBackofficeAPI.Repositories
{
    public class CurrencyRepository : IRepository<Currency>
    {
        private DivisasContext Context { get; set; }
        public DbSet<Currency> Currencies { get; }

        public CurrencyRepository(DivisasContext context)
        {
            Context = context;
            Currencies = context.Currencies; 
        }

        public async Task Create(Currency toCreate)
        {
            await Currencies.AddAsync(toCreate);
            await SaveChangesAsync();
        }

        public async Task Delete(int id)
        {
            var toDelete = await Currencies.FirstOrDefaultAsync(x => x.Id == id);
            Currencies.Remove(toDelete);
            await SaveChangesAsync();
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
                if (this.Context != null)
                {
                    this.Context.Dispose();
                    this.Context = null;
                }
            }
        }

        public async Task<IEnumerable<Currency>> Get()
        {
            var result = await Currencies.ToListAsync();
            return result;
        }

        public async Task<Currency> Get(int id)
        {
            var result = await Currencies.FirstOrDefaultAsync(x => x.Id == id);
            return result;
        }

        public async Task SaveChangesAsync()
        {
            await Context.SaveChangesAsync();
        }

        public async Task Update(Currency toUpdate)
        {
            var retrieved = await Currencies.FirstOrDefaultAsync(x => x.Id == toUpdate.Id);

            Currencies.Remove(retrieved);
            Currencies.Add(toUpdate);

            await SaveChangesAsync();
        }
    }
}
