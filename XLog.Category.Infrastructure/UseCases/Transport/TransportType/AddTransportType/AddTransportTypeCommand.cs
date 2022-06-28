using System;
using MediatR;
using XLog.Category.Application.UseCases.GetTransportType;
using XLog.Category.Infrastructure.Dto;
using System.Collections.Generic;
using XLog.Category.Domain;

namespace XLog.Category.Infrastructure.UseCases.AddTransportType
{
    public class AddTransportTypeCommand : IRequest<AddTransportTypeResponse>, ICreateTransportType
    {
        public IEnumerable<AddTransportTypeItem> transportTypeItems {get;set;}
    }
}
