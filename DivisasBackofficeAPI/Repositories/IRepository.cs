using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DivisasBackofficeAPI.Repositories
{
    public interface IRepository<T> : IDisposable
    {
        Task<IEnumerable<T>> Get();
        Task<T> Get(int id);
        Task Delete(int id);
        Task Create(T toCreate);
        Task Update(T toUpdate);
        Task SaveChangesAsync();
    }
}
