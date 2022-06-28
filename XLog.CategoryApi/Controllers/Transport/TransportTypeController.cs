using System;
using System.Threading.Tasks;
using MediatR;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using XLog.Category.Infrastructure.UseCases.AddTransportType;
using XLog.Category.Infrastructure.UseCases.UpdateTransportType;
// using XLog.Category.Infrastructure.UseCases.DeleteTransportType;
using XLog.Category.Infrastructure.UseCases.GetTransportType;

namespace XLog.CategoryApi.Controllers
{
    //[Authorize]
    [ApiController]
    [Route("api/[controller]")]
    public class TransportTypeController : ControllerBase
    {

        [HttpGet("Get All Transport Type")]
        public async Task<IActionResult> GetAll([FromQuery] GetAllTransportTypeCommand command,[FromServices] IMediator mediator)
        {
            var result = await mediator.Send(command);
            return Ok(result);
        }

        [HttpPost("Create")]
        public async Task<IActionResult> Create([FromBody] AddTransportTypeCommand command, [FromServices] IMediator mediator)
        {
            var result = await mediator.Send(command);
            return Ok(result);
        }

        [HttpPost("Edit")]
        public async Task<IActionResult> Edit([FromBody] UpdateTransportTypeCommand command, [FromServices] IMediator mediator)
        {
            var result = await mediator.Send(command);
            return Ok(result);
        }

        // [HttpDelete("Delete Delivery Method By Code")]
        // public async Task<IActionResult> Delete(string id, [FromServices] IMediator mediator)
        // {
        //     var result = await mediator.Send(new DeleteTransportTypeCommand { ID = id });
        //     return Ok(result);
        // }
    }
}

