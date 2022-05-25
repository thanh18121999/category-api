using System.Net;
using System.Collections.Generic;
using XLog.Category.Domain;
using XLog.Category.Infrastructure.Dto;
using XLog.Category.Application.Persistence;

namespace XLog.Category.Infrastructure.UseCases.GetPartners
{
    public class GetPartnersResponse : BaseResponseList<PartnerDto>
    {
        public string message { get; set; } 
        public HttpStatusCode StatusCode { get; set; }
        public int TotalOfPartners { get; set; }
        public IEnumerable<PartnerDto> responses { get; set; } 
    }
}
