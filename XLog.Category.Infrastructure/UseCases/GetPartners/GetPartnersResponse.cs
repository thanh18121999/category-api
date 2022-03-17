using System.Collections.Generic;
using XLog.Category.Domain;
using XLog.Category.Infrastructure.Dto;

namespace XLog.Category.Infrastructure.UseCases.GetPartners
{
    public class GetPartnersResponse
    {
        public int TotalOfPartners { get; set; }
        public IEnumerable<PartnerDto> Partners { get; set; } 
    }
}
