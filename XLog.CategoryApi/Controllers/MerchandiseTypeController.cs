using System;
using System.Threading.Tasks;
using MediatR;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using XLog.Category.Infrastructure.UseCases.GetMerchandiseType;

namespace XLog.CategoryApi.Controllers
{
    //[Authorize]
    [ApiController]
    [Route("api/[controller]")]
    public class MerchandiseTypeController : ControllerBase
    {
        [HttpGet("get-merchandise-type-by-id")]
        public async Task<IActionResult> GetMerchandiseType([FromQuery] GetMerchandiseTypeCommand command, [FromServices] IMediator mediator)
        {
            var result = await mediator.Send(command);
            return Ok(result);
        }
        [HttpGet("GetAllMerchandiseType")]
        public async Task<IActionResult> GetAllMerchandiseType([FromQuery] GetAllMerchandiseTypeCommand command,[FromServices] IMediator mediator)
        {
            var result = await mediator.Send(command);
            return Ok(result);
        }
    }
}