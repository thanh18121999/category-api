using System;
using MediatR;
using XLog.Category.Application.UseCases.GetExtraService;
using System.Collections.Generic;

namespace XLog.Category.Infrastructure.UseCases.AddExtraService
{
    public class AddExtraServiceCommand : IRequest<AddExtraServiceResponse>, ICreateExtraService
    {
        public IEnumerable<AddExtraServiceItem> extraServiceItems {get;set;}
    }
}
