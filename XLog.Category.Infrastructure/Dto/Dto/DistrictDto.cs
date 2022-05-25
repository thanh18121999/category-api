using System;
using XLog.Category.Domain;
namespace XLog.Category.Infrastructure.Dto
{
    public class DistrictDto
    {
        public string DistrictId { get; set; }
        public string? Name { get; set; }
        public string CountryId { get; set; }
        public COUNTRY Country { get; set; }
        public string CityId { get; set; }
        public PROVINCES City { get; set; }
    }
}