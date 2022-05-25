using System.Net;
using System.Collections.Generic;
using XLog.Category.Domain;
using XLog.Category.Infrastructure.Dto;
using XLog.Category.Application.Persistence;

namespace XLog.Category.Infrastructure.UseCases.GetUserGroup
{
    public class GetAllUserGroupResponse : BaseResponseList<USERGROUPS>
    {
        public string message { get; set; } 
        public HttpStatusCode StatusCode { get; set; } 
        public IEnumerable<USERGROUPS> responses { get; set; } 
    }
}
