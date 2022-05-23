using AutoMapper;
using XLog.Category.Domain;
using XLog.Category.Application.UseCases.GetUserGroup;

namespace XLog.Category.Infrastructure.Dto
{
    public class UserGroupMappingProfile : Profile
    {
        public UserGroupMappingProfile()
        {
            CreateMap<Domain.USERGROUPS, UserGroupDto>(); 
            
        }
    }
    public class AddUserGroupMappingProfile : Profile
    {
        public AddUserGroupMappingProfile()
        {
            CreateMap<AddUserGroupItem, Domain.USERGROUPS>();

        }
    } 
}
