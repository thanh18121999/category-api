using System.Net;
using System.Collections.Generic;
using XLog.Category.Domain;
using XLog.Category.Infrastructure.Dto;
using XLog.Category.Application.Persistence;

namespace XLog.Category.Infrastructure.UseCases.GetTransportType
{
    public class GetAllTransportTypeResponse : BaseResponseList<TRANSPORTTYPES>
    {
        public string message { get; set; } 
        public HttpStatusCode StatusCode { get; set; } 
        public IEnumerable<TRANSPORTTYPES> responses { get; set; } 
    }
}
