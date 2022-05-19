using System.Net;
using System.Collections.Generic;
using XLog.Category.Domain;
using XLog.Category.Infrastructure.Dto;
using XLog.Category.Application.Persistence;

namespace XLog.Category.Infrastructure.UseCases.GetCountry
{
    public class GetCountryResponse : BaseResponse<COUNTRY>
    {
        public string message { get; set; } 
        public HttpStatusCode StatusCode { get; set; } 
        public COUNTRY responses { get; set; } 
    }

    public class GetAllCountryResponse : BaseResponseList<CountryDto>
    {
        public string message { get; set; } 
        public HttpStatusCode StatusCode { get; set; } 
        public IEnumerable<CountryDto> responses { get; set; } 
    }
}
