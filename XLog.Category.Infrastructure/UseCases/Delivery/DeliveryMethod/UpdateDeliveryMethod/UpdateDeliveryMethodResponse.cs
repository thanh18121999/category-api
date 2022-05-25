using System.Net;
using System.Collections.Generic;
using XLog.Category.Domain;
using XLog.Category.Infrastructure.Dto;
using XLog.Category.Application.Persistence;

namespace XLog.Category.Infrastructure.UseCases.UpdateDeliveryMethod
{
    public class UpdateDeliveryMethodResponse : BaseResponse<DeliveryMethodDto>
    {
        public string message { get; set; } 
        public HttpStatusCode StatusCode { get; set; } 
        public DeliveryMethodDto responses { get; set; } 
    }
}
