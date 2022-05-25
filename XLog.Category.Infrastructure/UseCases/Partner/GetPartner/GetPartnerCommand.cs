using System;
using MediatR;
using XLog.Category.Application.UseCases.GetPartners;
using XLog.Category.Infrastructure.UseCases.GetPartners;

namespace XLog.Category.Infrastructure.UseCases.GetPartner
{
    public class GetPartnerCommand : IRequest<GetPartnerResponse>, IGetPartner
    {
        public string PartnerId { get; set; }

    }
}
