using System;
using System.Threading.Tasks;
using MediatR;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using XLog.Category.Infrastructure.UseCases.GetExtraService;
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


    }
}
