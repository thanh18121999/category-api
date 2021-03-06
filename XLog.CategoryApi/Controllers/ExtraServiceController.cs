using System;
using System.Threading.Tasks;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using XLog.Category.Infrastructure.UseCases.GetExtraService;
using XLog.Category.Infrastructure.UseCases.AddExtraService;
using XLog.Category.Infrastructure.UseCases.UpdateExtraService;
using XLog.Category.Infrastructure.UseCases.DeleteExtraService;
namespace XLog.CategoryApi.Controllers
{
    //[Authorize]
    [ApiController]
    [Route("api/[controller]")]
    public class ExtraServiceController : ControllerBase
    {

        [HttpGet("GetById")]
        public async Task<IActionResult> GetExtraServiceById([FromQuery] GetExtraServiceCommand command, [FromServices] IMediator mediator)
        {
            var result = await mediator.Send(command);
            return Ok(result);
        }
        [HttpGet("GetAllExtraService")]
        public async Task<IActionResult> GetAllExtraService([FromQuery] GetAllExtraServiceCommand command,[FromServices] IMediator mediator)
        {
            var result = await mediator.Send(command);
            return Ok(result);
        }
        [HttpPost("Create")]
        public async Task<IActionResult> Create([FromBody] AddExtraServiceCommand command, [FromServices] IMediator mediator)
        {
            var result = await mediator.Send(command);
            return Ok(result);
        }

        [HttpPost("Edit")]
        public async Task<IActionResult> Edit([FromBody] UpdateExtraServiceCommand command, [FromServices] IMediator mediator)
        {
            var result = await mediator.Send(command);
            return Ok(result);
        }

        [HttpDelete("Delete Extra Service By ID")]
        public async Task<IActionResult> Delete(string id, [FromServices] IMediator mediator)
        {
            var result = await mediator.Send(new DeleteExtraServiceCommand { extraServiceID = id });
            return Ok(result);
        }
    }
}