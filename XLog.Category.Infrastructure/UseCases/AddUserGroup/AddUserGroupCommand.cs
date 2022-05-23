using System;
using MediatR;
using XLog.Category.Application.UseCases.GetUserGroup;
using XLog.Category.Infrastructure.Dto;
using System.Collections.Generic;
using XLog.Category.Domain;

namespace XLog.Category.Infrastructure.UseCases.AddUserGroup
{
    public class AddUserGroupCommand : IRequest<AddUserGroupResponse>, ICreateUserGroup
    {
        public IEnumerable<AddUserGroupItem> userGroupItems {get;set;}
    }
}
