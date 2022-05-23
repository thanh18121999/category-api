using System;
using MediatR;
using XLog.Category.Application.UseCases.DeletePartner;
using XLog.Category.Infrastructure.Dto;

namespace XLog.Category.Infrastructure.UseCases.DeletePartner
{
    public class DeletePartnerCommand : IRequest<DeletePartnerResponse>, IDeletePartner
    {
        public string PartnerId { get; set; }
    }
}
