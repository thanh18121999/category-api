using System;
using System.Threading.Tasks;
using MediatR;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using XLog.Category.Infrastructure.UseCases.GetPostalCode;

namespace XLog.CategoryApi.Controllers
{
    //[Authorize]
    [ApiController]
    [Route("api/[controller]")]
    public class PostalCodeController : ControllerBase
    {
        [HttpGet("GetByCountry-City-District-Ward")]
        public async Task<IActionResult> GetPostalCodeByCode([FromQuery] GetPostalCodeCommand command, [FromServices] IMediator mediator)
        {
            var result = await mediator.Send(command);
            return Ok(result);
        }
    }
}