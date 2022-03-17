using AutoMapper;
using XLog.Category.Domain;

namespace XLog.Category.Infrastructure.Dto
{
    public class CityMappingProfile : Profile
    {
        public CityMappingProfile()
        {
            CreateMap<CITY, CityDto>();

        }
    }
}
