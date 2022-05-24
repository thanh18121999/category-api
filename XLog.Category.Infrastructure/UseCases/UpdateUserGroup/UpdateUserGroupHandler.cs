using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using AutoMapper;
using AutoMapper.QueryableExtensions;
using MediatR;
using XLog.Category.Application.Persistence;
using XLog.Category.Domain;
using XLog.Category.Infrastructure.Dto;
//using XLog.Category.Infrastructure.Dto;
using XLog.Category.Application.UseCases.GetUserGroup;

namespace XLog.Category.Infrastructure.UseCases.UpdateUserGroup
{
    public class UpdateUserGroupHandler : IRequestHandler<UpdateUserGroupCommand, UpdateUserGroupResponse>
    {
        private readonly IUserGroupRepository _userGroupRepository;
        private readonly IMapper _mapper;

        public UpdateUserGroupHandler(IUserGroupRepository userGroupRepository, IMapper mapper)
        {
            _userGroupRepository = userGroupRepository;
            _mapper = mapper;
        }

        public async Task<UpdateUserGroupResponse> Handle(UpdateUserGroupCommand command, CancellationToken cancellationToken)
        {
            try {
                List<Domain.USERGROUPS> UpdatedUserGroups = new List<Domain.USERGROUPS>();
                foreach (UpdateUserGroupItem usergroupItem in command.userGroups)
                {
                    Domain.USERGROUPS usergroup = _mapper.Map<Domain.USERGROUPS>(usergroupItem);
                    _userGroupRepository.Update(usergroup);  
                    UpdatedUserGroups.Add(usergroup);               
                }
                await _userGroupRepository.SaveChangesAsync(cancellationToken);
                return new UpdateUserGroupResponse
                {
                    StatusCode = System.Net.HttpStatusCode.OK,
                    message = "Success",
                };
            }
            catch {
                return new UpdateUserGroupResponse
                {
                    StatusCode = System.Net.HttpStatusCode.InternalServerError,
                    message = "Error",
                }; 
            }
        }
    }
}
