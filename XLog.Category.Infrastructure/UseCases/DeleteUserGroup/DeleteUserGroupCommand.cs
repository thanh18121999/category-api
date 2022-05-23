using System;
using MediatR;
using XLog.Category.Application.UseCases.GetUserGroup;
using XLog.Category.Infrastructure.Dto;

namespace XLog.Category.Infrastructure.UseCases.DeleteUserGroup
{
    public class DeleteUserGroupCommand : IRequest<DeleteUserGroupResponse>, IDeleteUserGroup
    {
        public string userGroupID { get; set; }
    }
}
