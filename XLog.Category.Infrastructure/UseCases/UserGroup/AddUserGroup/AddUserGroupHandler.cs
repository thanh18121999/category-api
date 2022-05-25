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

namespace XLog.Category.Infrastructure.UseCases.AddUserGroup
{
    public class AddUserGroupHandler : IRequestHandler<AddUserGroupCommand, AddUserGroupResponse>
    {
        private readonly IUserGroupRepository _userGroupRepository;
        private readonly IMapper _mapper;

        public AddUserGroupHandler(IUserGroupRepository userGroupRepository, IMapper mapper)
        {
            _userGroupRepository = userGroupRepository;
            _mapper = mapper;
        }

        public async Task<AddUserGroupResponse> Handle(AddUserGroupCommand command, CancellationToken cancellationToken)
        {
            try {
                List<Domain.USERGROUPS> AddedUserGroups = new List<Domain.USERGROUPS>();
                foreach (AddUserGroupItem usergroupItem in command.userGroupItems)
                {
                    Domain.USERGROUPS usergroup = _mapper.Map<Domain.USERGROUPS>(usergroupItem);
                    await _userGroupRepository.AddAsync(usergroup, cancellationToken);  
                    AddedUserGroups.Add(usergroup);               
                }
                await _userGroupRepository.SaveChangesAsync(cancellationToken);
                return new AddUserGroupResponse
                {
                    StatusCode = System.Net.HttpStatusCode.OK,
                    message = "Success",
                };
            }
            catch {
                return new AddUserGroupResponse
                {
                    StatusCode = System.Net.HttpStatusCode.InternalServerError,
                    message = "Error",
                }; 
            }
        }
    }
}
