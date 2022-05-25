using System;
using System.Threading.Tasks;
using MediatR;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using XLog.Category.Infrastructure.UseCases.AddDeliveryMethod;
using XLog.Category.Infrastructure.UseCases.UpdateDeliveryMethod;
using XLog.Category.Infrastructure.UseCases.DeleteDeliveryMethod;
using XLog.Category.Infrastructure.UseCases.GetDeliveryMethod;

namespace XLog.CategoryApi.Controllers
{
    //[Authorize]
    [ApiController]
    [Route("api/[controller]")]
    public class DeliveryMethodController : ControllerBase
    {

        [HttpGet("Get All Delivery Method")]
        public async Task<IActionResult> GetAll([FromQuery] GetAllDeliveryMethodCommand command,[FromServices] IMediator mediator)
        {
            var result = await mediator.Send(command);
            return Ok(result);
        }

        [HttpPost("Create")]
        public async Task<IActionResult> Create([FromBody] AddDeliveryMethodCommand command, [FromServices] IMediator mediator)
        {
            var result = await mediator.Send(command);
            return Ok(result);
        }

        [HttpPost("Edit")]
        public async Task<IActionResult> Edit([FromBody] UpdateDeliveryMethodCommand command, [FromServices] IMediator mediator)
        {
            var result = await mediator.Send(command);
            return Ok(result);
        }

        [HttpDelete("Delete Delivery Method By Code")]
        public async Task<IActionResult> Delete(string id, [FromServices] IMediator mediator)
        {
            var result = await mediator.Send(new DeleteDeliveryMethodCommand { ID = id });
            return Ok(result);
        }
    }
}

