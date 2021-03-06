using System.Net;
using System.Collections.Generic;
using XLog.Category.Domain;
using XLog.Category.Infrastructure.Dto;
using XLog.Category.Application.Persistence;

namespace XLog.Category.Infrastructure.UseCases.GetExtraService
{
    public class GetExtraServiceResponse : BaseResponse<EXTRASERVICE>
    {
        public string message { get; set; } 
        public HttpStatusCode StatusCode { get; set; } 
        public EXTRASERVICE responses { get; set; }
    }
    public class GetAllExtraServiceResponse : BaseResponseList<EXTRASERVICE>
    {
        public string message { get; set; } 
        public HttpStatusCode StatusCode { get; set; } 
        public IEnumerable<EXTRASERVICE> responses { get; set; } 
    }
}