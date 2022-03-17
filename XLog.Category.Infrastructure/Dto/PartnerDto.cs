using System;

namespace XLog.Category.Infrastructure.Dto
{
    public class PartnerDto
    {
        public PartnerDto(Guid partnerId, string fullName)
        {
            PartnerId = partnerId;
            FullName = fullName;
           
        }
        public Guid PartnerId { get; set; }
        public string? FullName { get; set; }
    }
}
