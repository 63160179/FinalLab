using Microsoft.EntityFrameworkCore;
using WebApplication2.models;
using System.Collections.Generic;

namespace WebApplication2.Database
{
    public class DataDbContext : DbContext
    {
        public DataDbContext(DbContextOptions<DataDbContext> options) : base(options) { }

        public DbSet<Employees> Employees { get; set; }

        public DbSet<Positions> Positions { get; set; }


    }
}
