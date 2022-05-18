using System;
using System.Threading.Tasks;
using MediatR;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using XLog.Category.Infrastructure.UseCases.AddPartner;
using XLog.Category.Infrastructure.UseCases.DeletePartner;
using XLog.Category.Infrastructure.UseCases.GetCountry;

namespace XLog.CategoryApi.Controllers
{
    //[Authorize]
    [ApiController]
    [Route("api/[controller]")]
    public class CountryController : ControllerBase
    {

        [HttpGet("GetById")]
        public async Task<IActionResult> GetCountryById([FromQuery] GetCountryByIdCommand command, [FromServices] IMediator mediator)
        {
            var result = await mediator.Send(command);
            return Ok(result);
        }


        [HttpGet("GetByCode")]
        public async Task<IActionResult> GetCountryByCode([FromQuery] GetCountryByCodeCommand command, [FromServices] IMediator mediator)
        {
            var result = await mediator.Send(command);
            return Ok(result);
        }


        [HttpGet("GetAllCountry")]
        public async Task<IActionResult> GetAllCountry([FromQuery] GetAllCountryCommand command,[FromServices] IMediator mediator)
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
