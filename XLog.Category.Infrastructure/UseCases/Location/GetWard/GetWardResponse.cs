using System.Net;
using System.Collections.Generic;
using XLog.Category.Domain;
using XLog.Category.Infrastructure.Dto;
using XLog.Category.Application.Persistence;

namespace XLog.Category.Infrastructure.UseCases.GetWard
{
    public class GetWardResponse : BaseResponseList<WARDS>
    {
        public string message { get; set; } 
        public HttpStatusCode StatusCode { get; set; } 
        public IEnumerable<WARDS> responses { get; set; } 
    }

    public class GetAllWardResponse : BaseResponseList<WARDS>
    {
        public string message { get; set; } 
        public HttpStatusCode StatusCode { get; set; } 
        public IEnumerable<WARDS> responses { get; set; } 
    }
}
