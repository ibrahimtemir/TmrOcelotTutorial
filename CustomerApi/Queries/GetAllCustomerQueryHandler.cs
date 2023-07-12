using CustomerApi.Requests;
using CustomerApi.Responses;
using MediatR;

namespace CustomerApi.Queries
{
    public class GetAllCustomerQueryHandler : IRequestHandler<GetAllCustomerRequest, GetAllCustomerResponse>
    {
        public async Task<GetAllCustomerResponse> Handle(GetAllCustomerRequest request, CancellationToken cancellationToken)
        {
            Console.WriteLine("GetAll Customer");
            return new GetAllCustomerResponse { Success = true };
        }
    }
}
