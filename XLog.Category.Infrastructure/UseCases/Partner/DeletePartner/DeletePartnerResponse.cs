using System.Net;
using System.Collections.Generic;
using XLog.Category.Domain;
using XLog.Category.Infrastructure.Dto;
using XLog.Category.Application.Persistence;

namespace XLog.Category.Infrastructure.UseCases.DeletePartner
{
    public class DeletePartnerResponse : BaseResponse<PARTNERS>
    {
        public string message { get; set; } 
        public HttpStatusCode StatusCode { get; set; } 
        public PARTNERS responses { get; set; } 
    }
}
