using EventFlow;
using EventFlowTemplate.API.ViewModels.Example;
using EventFlowTemplate.Application.Commands.Example.CreateExample;
using EventFlowTemplate.Domain;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace EventFlowTemplate.API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ExampleController :
        ControllerBase
    {
        private readonly ICommandBus _bus;
        public ExampleController(ICommandBus bus)
        {
            _bus = bus;
        }

        [HttpPost]
        public async Task<IActionResult> PostAsync([FromBody]CreateExampleViewModel vm, CancellationToken cancellationToken = default)
        {
            var command = new CreateExampleCommand(ExampleId.New, vm.MagicNumber);
            var result = await _bus.PublishAsync(command, cancellationToken);
            return result.IsSuccess ? Ok() : (IActionResult)BadRequest();
        }
    }
}
