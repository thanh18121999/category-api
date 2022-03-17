using System;
using MediatR;
using XLog.Category.Application.UseCases.AddPartner;
using XLog.Category.Infrastructure.Dto;

namespace XLog.Category.Infrastructure.UseCases.AddPartner
{
    public class AddPartnerCommand : IRequest<PartnerDto>, IAddPartner
    {
        public string PartnerId { get; set; }
        public string Name { get; set; }
    }
}
