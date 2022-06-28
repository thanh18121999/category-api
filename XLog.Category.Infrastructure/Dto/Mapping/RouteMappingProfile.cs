using AutoMapper;
using XLog.Category.Domain;
using XLog.Category.Application.UseCases.GetRoute;

namespace XLog.Category.Infrastructure.Dto
{
    public class RouteMappingProfile : Profile
    {
        public RouteMappingProfile()
        {
            CreateMap<Domain.ROUTES, RouteDto>(); 
            
        }
    }
    public class AddRouteMappingProfile : Profile
    {
        public AddRouteMappingProfile()
        {
            CreateMap<AddRouteItem, Domain.ROUTES>();

        }
    } 
    public class UpdateRouteMappingProfile : Profile
    {
        public UpdateRouteMappingProfile()
        {
            CreateMap<UpdateRouteItem, Domain.ROUTES>();

        }
    } 
}
