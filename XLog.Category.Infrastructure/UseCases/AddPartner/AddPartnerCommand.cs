using System;
using MediatR;
using System.Collections.Generic;
using XLog.Category.Application.UseCases.AddPartner;
using XLog.Category.Infrastructure.Dto;

namespace XLog.Category.Infrastructure.UseCases.AddPartner
{
    public class AddPartnerCommand : IRequest<AddPartnerResponse>, ICreatePartner
    {
        public IEnumerable<AddPartnerItem> PartnerItems {get;set;}
    }
}
