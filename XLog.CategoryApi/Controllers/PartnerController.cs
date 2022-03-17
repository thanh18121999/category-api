using System;
using System.Threading.Tasks;
using MediatR;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using XLog.Category.Infrastructure.UseCases.AddPartner;
using XLog.Category.Infrastructure.UseCases.DeletePartner;
using XLog.Category.Infrastructure.UseCases.GetPartners;

namespace XLog.CategoryApi.Controllers
{
    //[Authorize]
    [ApiController]
    [Route("api/[controller]")]
    public class PartnerController : ControllerBase
    {

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

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(string id, [FromServices] IMediator mediator)
        {
            var result = await mediator.Send(new DeletePartnerCommand { PartnerId = id });
            return Ok(result);
        }


    }
}