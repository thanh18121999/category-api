using System.Collections.Generic;
using XLog.Category.Domain;
using XLog.Category.Infrastructure.Dto;

namespace XLog.Category.Infrastructure.UseCases.GetCity
{
    public class GetCityResponse
    {
        public CITY city { get; set; } 
    }

    public class GetAllCityResponse
    {
        public IEnumerable<CityDto> cities { get; set; } 
    }
}
