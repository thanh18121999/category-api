using System.Net;
using System.Collections.Generic;
using XLog.Category.Domain;
using XLog.Category.Infrastructure.Dto;
using XLog.Category.Application.Persistence;

namespace XLog.Category.Infrastructure.UseCases.GetPartnerType
{
    public class GetPartnerTypeResponse : BaseResponse<PARTNERTYPE>
    {
        public string message { get; set; } 
        public HttpStatusCode StatusCode { get; set; }
        public PARTNERTYPE responses { get; set; } 
    }
}
