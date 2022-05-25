using System;
using MediatR;
using XLog.Category.Application.UseCases.GetUserGroup;
using XLog.Category.Infrastructure.Dto;
using System.Collections.Generic;
using XLog.Category.Domain;

namespace XLog.Category.Infrastructure.UseCases.UpdateUserGroup
{
    public class UpdateUserGroupCommand : IRequest<UpdateUserGroupResponse>, IUpdateUserGroup
    {
        public IEnumerable<UpdateUserGroupItem> userGroups {get;set;}
    }
}
