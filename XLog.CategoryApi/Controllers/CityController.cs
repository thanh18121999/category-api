using System;
using System.Threading.Tasks;
using MediatR;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using XLog.Category.Infrastructure.UseCases.AddPartner;
using XLog.Category.Infrastructure.UseCases.DeletePartner;
using XLog.Category.Infrastructure.UseCases.GetCity;

namespace XLog.CategoryApi.Controllers
{
    //[Authorize]
    [ApiController]
    [Route("api/[controller]")]
    public class CityController : ControllerBase
    {

        [HttpGet("GetByCode")]
        public async Task<IActionResult> GetCityByCode([FromQuery] GetCityCommand command, [FromServices] IMediator mediator)
        {
            var result = await mediator.Send(command);
            return Ok(result);
        }


        [HttpGet("GetAllCityByCountryCode")]
        public async Task<IActionResult> GetAllCities([FromQuery] GetAllCityByCountryCodeCommand command, [FromServices] IMediator mediator)
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
