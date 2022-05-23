using System;
using System.Threading.Tasks;
using MediatR;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using XLog.Category.Infrastructure.UseCases.AddPartner;
using XLog.Category.Infrastructure.UseCases.DeletePartner;
using XLog.Category.Infrastructure.UseCases.GetPartner;
using XLog.Category.Infrastructure.UseCases.GetPartners;

namespace XLog.CategoryApi.Controllers
{
    //[Authorize]
    [ApiController]
    [Route("api/[controller]")]
    public class PartnerController : ControllerBase
    {

        [HttpGet("get-partner-by-id")]
        public async Task<IActionResult> GetPartnerByID([FromQuery] GetPartnerCommand command, [FromServices] IMediator mediator)
        {
            var result = await mediator.Send(command);
            return Ok(result);
        }
        [HttpGet("GetAll")]
        public async Task<IActionResult> GetPartners([FromQuery] GetPartnersCommand command, [FromServices] IMediator mediator)
        {

            var result = await mediator.Send(command);
            return Ok(result);
        }

        [HttpPost]
        public async Task<IActionResult> Create([FromBody] AddPartnerCommand command, [FromServices] IMediator mediator)
        {
            var result = await mediator.Send(command);
            return Ok(result);
        }

        [HttpDelete("Delete Partner By ID")]
        public async Task<IActionResult> Delete(string id, [FromServices] IMediator mediator)
        {
            var result = await mediator.Send(new DeletePartnerCommand { PartnerId = id });
            return Ok(result);
        }


    }
}
