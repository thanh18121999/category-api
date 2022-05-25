using System.Net;
using System.Threading;
using System.Threading.Tasks;
using AutoMapper;
using MediatR;
using XLog.Category.Application.Persistence;
using XLog.Category.Domain;
using XLog.Category.Infrastructure.UseCases.DeleteUserGroup;

namespace XLog.Category.Infrastructure.UseCases.DeleteUserGrouup
{
    public class DeleteUserGroupHandler : IRequestHandler<DeleteUserGroupCommand, DeleteUserGroupResponse>
    {
        private readonly IUserGroupRepository _userGroupRepository;
        private readonly IMapper _mapper;

        public DeleteUserGroupHandler(IUserGroupRepository userGroupRepository, IMapper mapper)
        {
            _userGroupRepository = userGroupRepository;
            _mapper = mapper;
        }

        public async Task<DeleteUserGroupResponse> Handle(DeleteUserGroupCommand command, CancellationToken cancellationToken)
        {
            try {
                _userGroupRepository.Remove(new USERGROUPS { ID = command.userGroupID });
                var result = await _userGroupRepository.SaveChangesAsync(cancellationToken);
                return new DeleteUserGroupResponse {
                    StatusCode = System.Net.HttpStatusCode.OK,
                    message = "Success",
                };
            }
            catch {
                return new DeleteUserGroupResponse {
                    StatusCode = System.Net.HttpStatusCode.InternalServerError,
                    message = "Error",
                }; 
            }
            
        }
    }
}
