using System;
using MediatR;
using XLog.Category.Application.UseCases.GetPartnerType;

namespace XLog.Category.Infrastructure.UseCases.GetPartnerType
{
    public class GetPartnerTypeCommand : IRequest<GetPartnerTypeResponse>, IGetPartnerType
    {
        public string PartnerTypeID { get; set; }
    }
}
