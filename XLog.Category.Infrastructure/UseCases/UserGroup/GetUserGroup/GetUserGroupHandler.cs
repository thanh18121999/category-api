using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using AutoMapper;
using AutoMapper.QueryableExtensions;
using MediatR;
using XLog.Category.Application.Persistence;
using XLog.Category.Domain;
using XLog.Category.Infrastructure.Dto;
using XLog.Category.Infrastructure.Persistence;

namespace XLog.Category.Infrastructure.UseCases.GetUserGroup
{
    public class GetAllUserGroupHandler : IRequestHandler<GetAllUserGroupCommand, GetAllUserGroupResponse>
    {
        private readonly IUserGroupRepository _userGroupRepository;
        private readonly IMapper _mapper;

        public GetAllUserGroupHandler(IUserGroupRepository userGroupRepository, IMapper mapper)
        {
            _userGroupRepository = userGroupRepository;
            _mapper = mapper;
        }

        public async Task<GetAllUserGroupResponse> Handle(GetAllUserGroupCommand command, CancellationToken cancellationToken)
        {
            try {
                var usergroups = await _userGroupRepository.GetAll(cancellationToken);

                return new GetAllUserGroupResponse
                {
                    StatusCode = System.Net.HttpStatusCode.OK,
                    message = "Success",
                    responses = _mapper.Map<IEnumerable<USERGROUPS>>(usergroups)
                };
            }
            catch {
                return new GetAllUserGroupResponse
                {
                    StatusCode = System.Net.HttpStatusCode.InternalServerError,
                    message = "Error",
                };
            }
        }

         
    }
}
