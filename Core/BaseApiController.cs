using MediatR;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core
{
    [Route("api/[controller]")]
    [ApiController]
    public class BaseApiController<T> : ControllerBase
    {
        protected internal readonly IServiceProvider _serviceProvider;

        private IMediator _mediator;
        protected IMediator Mediator => _mediator ??= _serviceProvider.GetService<IMediator>();

        public BaseApiController(IServiceProvider serviceProvider)
        {
            _serviceProvider = serviceProvider;
        }
    }
}
