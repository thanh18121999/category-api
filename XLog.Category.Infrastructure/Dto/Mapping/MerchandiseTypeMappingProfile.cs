using AutoMapper;
using XLog.Category.Domain;

namespace XLog.Category.Infrastructure.Dto
{
    public class MerchandiseTypeMappingProfile : Profile
    {
        public MerchandiseTypeMappingProfile()
        {
            CreateMap<MERCHANDISETYPE, MerchandiseTypeDto>();

        }
    }
}
