using CustomerApi.Base;
using CustomerApi.Entities;
using CustomerApi.Requests;
using CustomerApi.Responses;
using CustomerrApi.Repositories;
using MediatR;

namespace CustomerApi.Commands
{
    public class CreateCustomerCommandHandler : IRequestHandler<CreateCustomerRequest, CreateCustomerResponse>
    {
        private readonly ICustomerRepository _customerRepository;
        private readonly IUnitOfWork _unitOfWork;

        public CreateCustomerCommandHandler(ICustomerRepository customerRepository, IUnitOfWork unitOfWork)
        {
            _customerRepository = customerRepository;
            _unitOfWork = unitOfWork;
        }

        public async Task<CreateCustomerResponse> Handle(CreateCustomerRequest request, CancellationToken cancellationToken)
        {
            Console.Write("create customer.....");

            var customer = new Customer
            {
                Id = new Guid(),
                Address = request.Address,
                Email = request.Email,
                LastName = request.LastName,
                Name = request.Name,
                Phone = request.Phone
            };

            await _customerRepository.Add(customer);
            var res = await _unitOfWork.SaveChangesAsync();

            return new CreateCustomerResponse { Message = "Customer Created 3", Result = res };
        }
    }
}
