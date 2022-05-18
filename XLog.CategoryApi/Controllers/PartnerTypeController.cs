using System;
using System.Threading.Tasks;
using MediatR;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using XLog.Category.Infrastructure.UseCases.GetPartnerType;

namespace XLog.CategoryApi.Controllers
{
    //[Authorize]
    [ApiController]
    [Route("api/[controller]")]
    public class PartnerTypeController : ControllerBase
    {
        [HttpGet("get-partner-type-by-id")]
        public async Task<IActionResult> GetPartnerType([FromQuery] GetPartnerTypeCommand command, [FromServices] IMediator mediator)
        {

            var result = await mediator.Send(command);
            return Ok(result);
        }
    }
}