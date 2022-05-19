using AutoMapper;
using XLog.Category.Domain;

namespace XLog.Category.Infrastructure.Dto
{
    public class DistrictMappingProfile : Profile
    {
        public DistrictMappingProfile()
        {
            CreateMap<DISTRICTS, DistrictDto>();

        }
    }
}
