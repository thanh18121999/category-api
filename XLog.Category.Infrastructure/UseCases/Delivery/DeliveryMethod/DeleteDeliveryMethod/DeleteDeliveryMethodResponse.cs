using System.Net;
using System.Collections.Generic;
using XLog.Category.Domain;
using XLog.Category.Infrastructure.Dto;
using XLog.Category.Application.Persistence;

namespace XLog.Category.Infrastructure.UseCases.DeleteDeliveryMethod
{
    public class DeleteDeliveryMethodResponse : BaseResponse<DELIVERYMETHODS>
    {
        public string message { get; set; } 
        public HttpStatusCode StatusCode { get; set; } 
        public DELIVERYMETHODS responses { get; set; } 
    }
}
