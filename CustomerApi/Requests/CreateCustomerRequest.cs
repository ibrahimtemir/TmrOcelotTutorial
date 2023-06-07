using CustomerApi.Responses;
using MediatR;

namespace CustomerApi.Requests
{
    public class CreateCustomerRequest : IRequest<CreateCustomerResponse>
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string LastName { get; set; }
    }
}
