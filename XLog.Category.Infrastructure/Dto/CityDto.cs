using System;
using XLog.Category.Domain;
namespace XLog.Category.Infrastructure.Dto
{
    public class CityDto
    {
        public CityDto(Guid cityId, string name, Guid countryId, COUNTRY country, int isActive)
        {
            CityId = cityId;
            Name = name;
            CountryId = countryId;
            Country = country;
            IsActive = isActive;
           
        }
        public Guid CityId { get; set; }
        public string? Name { get; set; }
        public Guid CountryId { get; set; }
        public COUNTRY Country { get; set; }
        public int IsActive { get; set; }
    }
}
