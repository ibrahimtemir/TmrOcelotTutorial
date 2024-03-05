using CustomerApi.Base;
using CustomerApi.Entities;

namespace CustomerrApi.Repositories
{
    public interface ICustomerRepository
    {
        Task Add(Customer entity);
    }
}
