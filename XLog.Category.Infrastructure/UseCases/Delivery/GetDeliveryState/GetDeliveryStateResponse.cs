using System.Net;
using System.Collections.Generic;
using XLog.Category.Domain;
using XLog.Category.Infrastructure.Dto;
using XLog.Category.Application.Persistence;

namespace XLog.Category.Infrastructure.UseCases.GetDeliveryState
{
    public class GetAllDeliveryStateResponse : BaseResponseList<DELIVERYSTATES>
    {
        public string message { get; set; } 
        public HttpStatusCode StatusCode { get; set; } 
        public IEnumerable<DELIVERYSTATES> responses { get; set; } 
    }
}
