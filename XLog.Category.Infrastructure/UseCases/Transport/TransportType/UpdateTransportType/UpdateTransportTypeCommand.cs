using System;
using MediatR;
using XLog.Category.Application.UseCases.GetTransportType;
using XLog.Category.Infrastructure.Dto;
using System.Collections.Generic;
using XLog.Category.Domain;

namespace XLog.Category.Infrastructure.UseCases.UpdateTransportType
{
    public class UpdateTransportTypeCommand : IRequest<UpdateTransportTypeResponse>, IUpdateTransportType
    {
        public IEnumerable<UpdateTransportTypeItem> transportTypes {get;set;}
    }
}
