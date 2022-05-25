using System;
using XLog.Category.Domain;
namespace XLog.Category.Infrastructure.Dto
{
    public class CityDto
    {
        public string CityId { get; set; }
        public string? Name { get; set; }
        public string CountryId { get; set; }
        public COUNTRY Country { get; set; }
    }
}
