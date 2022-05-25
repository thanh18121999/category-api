using System.Net;
using System.Collections.Generic;
using XLog.Category.Domain;
using XLog.Category.Infrastructure.Dto;
using XLog.Category.Application.Persistence;

namespace XLog.Category.Infrastructure.UseCases.UpdateUserGroup
{
    public class UpdateUserGroupResponse : BaseResponse<UserGroupDto>
    {
        public string message { get; set; } 
        public HttpStatusCode StatusCode { get; set; } 
        public UserGroupDto responses { get; set; } 
    }
}
