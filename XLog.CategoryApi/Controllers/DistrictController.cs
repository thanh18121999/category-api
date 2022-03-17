using System;
using System.Threading.Tasks;
using MediatR;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using XLog.Category.Infrastructure.UseCases.AddPartner;
using XLog.Category.Infrastructure.UseCases.DeletePartner;
using XLog.Category.Infrastructure.UseCases.GetDistrict;

namespace XLog.CategoryApi.Controllers
{
    //[Authorize]
    [ApiController]
    [Route("api/[controller]")]
    public class DistrictController : ControllerBase
    {

        [HttpGet("GetByCode")]
        public async Task<IActionResult> GetDistrictByCode([FromQuery] GetDistrictCommand command, [FromServices] IMediator mediator)
        {
            var result = await mediator.Send(command);
            return Ok(result);
        }


        [HttpGet("GetAllDistricts")]
        public async Task<IActionResult> GetAllDistricts([FromQuery] GetAllDistrictCommand command, [FromServices] IMediator mediator)
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
