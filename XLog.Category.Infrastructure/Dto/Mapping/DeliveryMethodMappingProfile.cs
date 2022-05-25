using AutoMapper;
using XLog.Category.Domain;
using XLog.Category.Application.UseCases.GetDeliveryMethod;

namespace XLog.Category.Infrastructure.Dto
{
    public class DeliveryMethodMappingProfile : Profile
    {
        public DeliveryMethodMappingProfile()
        {
            CreateMap<Domain.DELIVERYMETHODS, DeliveryMethodDto>(); 
            
        }
    }
    public class AddDeliveryMethodMappingProfile : Profile
    {
        public AddDeliveryMethodMappingProfile()
        {
            CreateMap<AddDeliveryMethodItem, Domain.DELIVERYMETHODS>();

        }
    } 
    public class UpdateDeliveryMethodMappingProfile : Profile
    {
        public UpdateDeliveryMethodMappingProfile()
        {
            CreateMap<UpdateDeliveryMethodItem, Domain.DELIVERYMETHODS>();

        }
    } 
}
