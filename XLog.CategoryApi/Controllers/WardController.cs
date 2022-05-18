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
        public async Task<IActionResult> GetByWard_District_City_Country_Code([FromQuery] GetWardCommand command, [FromServices] IMediator mediator)
        {
            var result = await mediator.Send(command);
            return Ok(result);
        }
        [HttpGet("GetAllWardByDistrictCityCountryCode")]
        public async Task<IActionResult> GetAllByDistrict_City_CountryCode([FromQuery] GetAllWardCommand command, [FromServices] IMediator mediator)
        {
            var result = await mediator.Send(command);
            return Ok(result);
        }
    }
}
