using AutoMapper;
using XLog.Category.Domain;

namespace XLog.Category.Infrastructure.Dto
{
    public class PartnerMappingProfile : Profile
    {
        public PartnerMappingProfile()
        {
            CreateMap<PARTNER, PartnerDto>();

        }
    }
}
