using CustomerApi.Entities;
using CustomerApi.EntityConfigurations;
using Microsoft.EntityFrameworkCore;

namespace CustomerApi.Base
{
    public class RepositoryContext : DbContext
    {
        public RepositoryContext(DbContextOptions<RepositoryContext> options)
           : base(options)
        {
        }
        public virtual DbSet<Customer> Customers { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new CustomerConfiguration());
        }
    }
}
