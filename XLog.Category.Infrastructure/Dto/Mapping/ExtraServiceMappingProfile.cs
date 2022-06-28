using AutoMapper;
using XLog.Category.Domain;
using XLog.Category.Application.UseCases.GetExtraService;

namespace XLog.Category.Infrastructure.Dto
{
    public class UserExtraServiceProfile : Profile
    {
        public UserExtraServiceProfile()
        {
            CreateMap<Domain.EXTRASERVICE, ExtraServiceDto>(); 
            
        }
    }
    public class AddExtraServiceMappingProfile : Profile
    {
        public AddExtraServiceMappingProfile()
        {
            CreateMap<AddExtraServiceItem, Domain.EXTRASERVICE>();

        }
    } 
    public class UpdateExtraServiceMappingProfile : Profile
    {
        public UpdateExtraServiceMappingProfile()
        {
            CreateMap<UpdateExtraServiceItem, Domain.EXTRASERVICE>();

        }
    } 
}
