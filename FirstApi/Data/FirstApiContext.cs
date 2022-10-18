using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;

namespace FirstApi.Data
{
    public class FirstApiContext : DbContext

    {
        public DbSet<Employee> Employees { get; internal set; }

        public FirstApiContext(DbContextOptions<FirstApiContext> options)
           : base(options)
        {
        }
    }
}