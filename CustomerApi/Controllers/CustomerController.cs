using CustomerApi.Requests;
using CustomerApi.Responses;
using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CustomerApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CustomerController : ControllerBase
    {
        protected internal readonly IMediator _mediator;
        public CustomerController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpPost("Create")]
        public async Task<CreateCustomerResponse> Create(CreateCustomerRequest request) => await _mediator.Send(request);

        [HttpGet("GetAll")]
        public async Task<GetAllCustomerResponse> GetAll(GetAllCustomerRequest request) => await _mediator.Send(request);
    }
}
