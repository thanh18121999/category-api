using System.Net;
using System.Collections.Generic;
using XLog.Category.Domain;
using XLog.Category.Infrastructure.Dto;
using XLog.Category.Application.Persistence;

namespace XLog.Category.Infrastructure.UseCases.GetMerchandiseType
{
    public class GetMerchandiseTypeResponse : BaseResponse<MERCHANDISETYPE>
    {
        public string message { get; set; } 
        public HttpStatusCode StatusCode { get; set; } 
        public MERCHANDISETYPE responses { get; set; }
    }
    public class GetAllMerchandiseTypeResponse : BaseResponseList<MerchandiseTypeDto>
    {
        public string message { get; set; } 
        public HttpStatusCode StatusCode { get; set; } 
        public IEnumerable<MerchandiseTypeDto> responses { get; set; }
    }
}
