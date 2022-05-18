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
        public async Task<IActionResult> GetByDistrict_City_Country_Code([FromQuery] GetDistrictCommand command, [FromServices] IMediator mediator)
        {
            var result = await mediator.Send(command);
            return Ok(result);
        }
        [HttpGet("GetAllDistrictByCityCountryCode")]
        public async Task<IActionResult> GetAllByCity_CountryCode([FromQuery] GetAllDistrictCommand command, [FromServices] IMediator mediator)
        {
            var result = await mediator.Send(command);
            return Ok(result);
        }
    }
}
