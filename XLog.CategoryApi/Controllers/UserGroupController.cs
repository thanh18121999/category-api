using System;
using System.Threading.Tasks;
using MediatR;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using XLog.Category.Infrastructure.UseCases.GetUserGroup;
using XLog.Category.Infrastructure.UseCases.AddUserGroup;
using XLog.Category.Infrastructure.UseCases.DeleteUserGroup;

namespace XLog.CategoryApi.Controllers
{
    //[Authorize]
    [ApiController]
    [Route("api/[controller]")]
    public class UserGroupController : ControllerBase
    {

        [HttpGet("GetAllUserGroup")]
        public async Task<IActionResult> GetAll([FromQuery] GetAllUserGroupCommand command,[FromServices] IMediator mediator)
        {
            var result = await mediator.Send(command);
            return Ok(result);
        }

        [HttpPost("Create")]
        public async Task<IActionResult> Create([FromBody] AddUserGroupCommand command, [FromServices] IMediator mediator)
        {
            var result = await mediator.Send(command);
            return Ok(result);
        }
        // [HttpDelete("Edit")]
        // public async Task<IActionResult> Delete(string id, [FromServices] IMediator mediator)
        // {
        //     var result = await mediator.Send(new DeleteUserGroupCommand { userGroupID = id });
        //     return Ok(result);
        // }

        [HttpDelete("Delete User Group By ID")]
        public async Task<IActionResult> Delete(string id, [FromServices] IMediator mediator)
        {
            var result = await mediator.Send(new DeleteUserGroupCommand { userGroupID = id });
            return Ok(result);
        }
    }
}
