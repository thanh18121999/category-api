using System;

namespace XLog.Category.Infrastructure.Dto
{
    public class PartnerDto
    {
        public PartnerDto(string id, string fullName)
        {
            Id = id;
            FullName = fullName;
           
        }
        public string? Id { get; set; }
        public string? FullName { get; set; }
    }
}
