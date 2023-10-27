using ProductApi.Responses;
using MediatR;

namespace CustomerApi.Requests
{
    public class CreateProductRequest : IRequest<CreateProductResponse>
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string LastName { get; set; }
    }
}
