using System.Net;
using System.Collections.Generic;
using XLog.Category.Domain;
using XLog.Category.Infrastructure.Dto;
using XLog.Category.Application.Persistence;

namespace XLog.Category.Infrastructure.UseCases.GetDistrict
{
    public class GetDistrictResponse : BaseResponseList<DISTRICTS>
    {
        public string message { get; set; } 
        public HttpStatusCode StatusCode { get; set; } 
        public IEnumerable<DISTRICTS> responses { get; set; } 
    }

    public class GetAllDistrictResponse: BaseResponseList<DISTRICTS>
    {
        public string message { get; set; } 
        public HttpStatusCode StatusCode { get; set; } 
        public IEnumerable<DISTRICTS> responses { get; set; } 
    }
}
