using System.Net;
using System.Collections.Generic;
using XLog.Category.Domain;
using XLog.Category.Infrastructure.Dto;
using XLog.Category.Application.Persistence;

namespace XLog.Category.Infrastructure.UseCases.DeleteUserGroup
{
    public class DeleteUserGroupResponse : BaseResponse<USERGROUPS>
    {
        public string message { get; set; } 
        public HttpStatusCode StatusCode { get; set; } 
        public USERGROUPS responses { get; set; } 
    }
}
