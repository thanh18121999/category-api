using AutoMapper;
using XLog.Category.Domain;

namespace XLog.Category.Infrastructure.Dto
{
    public class CountryMappingProfile : Profile
    {
        public CountryMappingProfile()
        {
            CreateMap<COUNTRY, CountryDto>();

        }
    }
}
