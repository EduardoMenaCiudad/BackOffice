using DivisasBackofficeAPI.Entities;
using JetBrains.Annotations;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DivisasBackofficeAPI.DatabaseContext
{
    public class DivisasContext : DbContext
    {
        public DbSet<Transaction> Transactions { get; set; }
        public DbSet<Currency> Currencies { get; set; }
        public DbSet<Exchange>  Exchanges{ get; set; }
        public DbSet<Person> People { get; set; }


        public DivisasContext(DbContextOptions options) : base(options)
        {
        }
    }
}
