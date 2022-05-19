using System.Net;
using System.Collections.Generic;
using XLog.Category.Domain;
using XLog.Category.Infrastructure.Dto;
using XLog.Category.Application.Persistence;

namespace XLog.Category.Infrastructure.UseCases.GetCity
{
    public class GetCityResponse : BaseResponseList<PROVINCES>
    {
        public string message { get; set; } 
        public HttpStatusCode StatusCode { get; set; } 
        public IEnumerable<PROVINCES> responses { get; set; } 
    }

    public class GetAllCityResponse : BaseResponseList<PROVINCES>
    {
        public string message { get; set; } 
        public HttpStatusCode StatusCode { get; set; } 
        public IEnumerable<PROVINCES> responses { get; set; } 
    }
}
