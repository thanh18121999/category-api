using AutoMapper;
using XLog.Category.Application.UseCases.AddPartner;
using XLog.Category.Domain;

namespace XLog.Category.Infrastructure.Dto
{
    public class PartnerMappingProfile : Profile
    {
        public PartnerMappingProfile()
        {
            CreateMap<PARTNERS, PartnerDto>();

        }  
    }
    public class AddPartnerMappingProfile : Profile
    {
        public AddPartnerMappingProfile()
        {
            CreateMap<AddPartnerItem, Domain.PARTNERS>();

        }
    } 
}
