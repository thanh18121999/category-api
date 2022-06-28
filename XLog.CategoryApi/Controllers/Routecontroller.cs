using System;
using System.Threading.Tasks;
using MediatR;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
// using XLog.Category.Infrastructure.UseCases.AddRoute;
// using XLog.Category.Infrastructure.UseCases.UpdateRoute;
// using XLog.Category.Infrastructure.UseCases.DeleteRoute;
using XLog.Category.Infrastructure.UseCases.GetRoute;

namespace XLog.CategoryApi.Controllers
{
    //[Authorize]
    [ApiController]
    [Route("api/[controller]")]
    public class RouteController : ControllerBase
    {

        [HttpGet("Get All Delivery Method")]
        public async Task<IActionResult> GetAll([FromQuery] GetAllRouteCommand command,[FromServices] IMediator mediator)
        {
            var result = await mediator.Send(command);
            return Ok(result);
        }

        // [HttpPost("Create")]
        // public async Task<IActionResult> Create([FromBody] AddRouteCommand command, [FromServices] IMediator mediator)
        // {
        //     var result = await mediator.Send(command);
        //     return Ok(result);
        // }

        // [HttpPost("Edit")]
        // public async Task<IActionResult> Edit([FromBody] UpdateRouteCommand command, [FromServices] IMediator mediator)
        // {
        //     var result = await mediator.Send(command);
        //     return Ok(result);
        // }

        // [HttpDelete("Delete Delivery Method By Code")]
        // public async Task<IActionResult> Delete(string id, [FromServices] IMediator mediator)
        // {
        //     var result = await mediator.Send(new DeleteRouteCommand { ID = id });
        //     return Ok(result);
        // }
    }
}

