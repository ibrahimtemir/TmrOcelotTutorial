using CustomerApi.Responses;
using MediatR;

namespace CustomerApi.Requests
{
    public class GetAllCustomerRequest : IRequest<GetAllCustomerResponse>
    {
    }
}
