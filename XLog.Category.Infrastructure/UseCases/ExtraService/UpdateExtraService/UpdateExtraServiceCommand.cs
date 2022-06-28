using System;
using MediatR;
using XLog.Category.Application.UseCases.GetExtraService;
using XLog.Category.Infrastructure.Dto;
using System.Collections.Generic;
using XLog.Category.Domain;

namespace XLog.Category.Infrastructure.UseCases.UpdateExtraService
{
    public class UpdateExtraServiceCommand : IRequest<UpdateExtraServiceResponse>, IUpdateExtraService
    {
        public IEnumerable<UpdateExtraServiceItem> extraServices {get;set;}
    }
}
