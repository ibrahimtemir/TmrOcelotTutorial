using CustomerApi.Requests;
using CustomerApi.Responses;
using MediatR;

namespace CustomerApi.Commands
{
    public class CreateCustomerCommandHandler : IRequestHandler<CreateCustomerRequest, CreateCustomerResponse>
    {
        public async Task<CreateCustomerResponse> Handle(CreateCustomerRequest request, CancellationToken cancellationToken)
        {
            return new CreateCustomerResponse { Message = "Customer Created" };
        }
    }
}
