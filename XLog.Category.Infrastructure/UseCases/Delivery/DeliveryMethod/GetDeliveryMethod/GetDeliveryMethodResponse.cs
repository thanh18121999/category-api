using System.Net;
using System.Collections.Generic;
using XLog.Category.Domain;
using XLog.Category.Infrastructure.Dto;
using XLog.Category.Application.Persistence;

namespace XLog.Category.Infrastructure.UseCases.GetDeliveryMethod
{
    public class GetAllDeliveryMethodResponse : BaseResponseList<DELIVERYMETHODS>
    {
        public string message { get; set; } 
        public HttpStatusCode StatusCode { get; set; } 
        public IEnumerable<DELIVERYMETHODS> responses { get; set; } 
    }
}
