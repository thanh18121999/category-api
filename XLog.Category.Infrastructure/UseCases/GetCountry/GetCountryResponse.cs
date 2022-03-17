using System.Collections.Generic;
using XLog.Category.Domain;
using XLog.Category.Infrastructure.Dto;

namespace XLog.Category.Infrastructure.UseCases.GetCountry
{
    public class GetCountryResponse
    {
        public COUNTRY country { get; set; } 
    }

    public class GetAllCountryResponse
    {
        public IEnumerable<CountryDto> countries { get; set; } 
    }
}
