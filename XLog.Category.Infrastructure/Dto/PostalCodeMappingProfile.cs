using AutoMapper;
using XLog.Category.Domain;

namespace XLog.Category.Infrastructure.Dto
{
    public class PostalCodeMappingProfile : Profile
    {
        public PostalCodeMappingProfile()
        {
            CreateMap<POSTALCODE, PostalCodeDto>();
        }
    }
}
