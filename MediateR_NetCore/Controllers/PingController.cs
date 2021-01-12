using MediatR;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MediateR_NetCore.Controllers
{

    [ApiController]
    [Route("[controller]")]
    public class PingController : ControllerBase
    {
        private readonly IMediator _mediator;

        public PingController(IMediator mediator)
        {
            _mediator = mediator;
        }


        [HttpGet]
        public async Task<IEnumerable<string>> Get()
        {
            return await _mediator.Send(new Queries.GetValuesQuery.Query());
        }

        [HttpPost]
        public async Task Post()
        {
            string userName = System.Security.Principal.WindowsIdentity.GetCurrent().Name;


            await _mediator.Send(new Commands.AddValueCommand.Command());
        }

    }
}
