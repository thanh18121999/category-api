using AutoMapper;
using XLog.Category.Domain;
using XLog.Category.Application.UseCases.GetTransportType;

namespace XLog.Category.Infrastructure.Dto
{
    public class TransportTypeMappingProfile : Profile
    {
        public TransportTypeMappingProfile()
        {
            CreateMap<Domain.TRANSPORTTYPES, TransportTypeDto>(); 
            
        }
    }
    public class AddTransportTypeMappingProfile : Profile
    {
        public AddTransportTypeMappingProfile()
        {
            CreateMap<AddTransportTypeItem, Domain.TRANSPORTTYPES>();

        }
    } 
    public class UpdateTransportTypeMappingProfile : Profile
    {
        public UpdateTransportTypeMappingProfile()
        {
            CreateMap<UpdateTransportTypeItem, Domain.TRANSPORTTYPES>();

        }
    } 
}
