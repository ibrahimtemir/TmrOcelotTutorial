using CustomerApi.Base;
using CustomerApi.Entities;
using CustomerrApi.Repositories;

namespace CustomerApi.Repositories
{
    public class CustomerRepository : ICustomerRepository
    {
        private readonly RepositoryContext _context;

        public CustomerRepository(RepositoryContext context)
        {
            _context = context;
        }

        public async Task Add(Customer entity)
        {
            await _context.Customers.AddAsync(entity);
        }
    }
}
