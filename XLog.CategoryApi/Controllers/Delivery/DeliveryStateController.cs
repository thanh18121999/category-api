using System;
using System.Threading.Tasks;
using MediatR;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using XLog.Category.Infrastructure.UseCases.GetDeliveryState;

namespace XLog.CategoryApi.Controllers
{
    //[Authorize]
    [ApiController]
    [Route("api/[controller]")]
    public class DeliveryStateController : ControllerBase
    {

        [HttpGet("GetAllDeliveryState")]
        public async Task<IActionResult> GetAll([FromQuery] GetAllDeliveryStateCommand command,[FromServices] IMediator mediator)
        {
            var result = await mediator.Send(command);
            return Ok(result);
        }
    }
}
