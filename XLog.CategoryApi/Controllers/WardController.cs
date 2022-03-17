using System;
using System.Threading.Tasks;
using MediatR;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using XLog.Category.Infrastructure.UseCases.AddPartner;
using XLog.Category.Infrastructure.UseCases.DeletePartner;
using XLog.Category.Infrastructure.UseCases.GetWard;

namespace XLog.CategoryApi.Controllers
{
    //[Authorize]
    [ApiController]
    [Route("api/[controller]")]
    public class WardController : ControllerBase
    {

        [HttpGet("GetByCode")]
        public async Task<IActionResult> GetWardByCode([FromQuery] GetWardCommand command, [FromServices] IMediator mediator)
        {
            var result = await mediator.Send(command);
            return Ok(result);
        }


        [HttpGet("GetAllWards")]
        public async Task<IActionResult> GetAllWards([FromQuery] GetAllWardCommand command, [FromServices] IMediator mediator)
        {
            var result = await mediator.Send(command);
            return Ok(result);
        }


        // [HttpPost]
        // public async Task<IActionResult> Create([FromBody] AddPartnerCommand command, [FromServices] IMediator mediator)
        // {
        //     var result = await mediator.Send(command);
        //     return Ok(result);
        // }

        // [HttpDelete("{id}")]
        // public async Task<IActionResult> Delete(Guid id, [FromServices] IMediator mediator)
        // {
        //     var result = await mediator.Send(new DeletePartnerCommand { PartnerId = id });
        //     return Ok(result);
        //}


    }
}
