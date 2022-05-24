using System.Net;
using System.Collections.Generic;
using XLog.Category.Domain;
using XLog.Category.Infrastructure.Dto;
using XLog.Category.Application.Persistence;

namespace XLog.Category.Infrastructure.UseCases.GetPostalCode
{
    public class GetPostalCodeResponse: BaseResponseList<PostalCodeDto>
    {
        public string message { get; set; } 
        public HttpStatusCode StatusCode { get; set; } 
        public IEnumerable<PostalCodeDto> responses {get; set;}
    }
}