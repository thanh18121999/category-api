using System;
using MediatR;
using XLog.Category.Application.UseCases.GetDeliveryMethod;
using XLog.Category.Infrastructure.Dto;

namespace XLog.Category.Infrastructure.UseCases.DeleteDeliveryMethod
{
    public class DeleteDeliveryMethodCommand : IRequest<DeleteDeliveryMethodResponse>, IDeleteDeliveryMethod
    {
        public string ID { get; set; }
    }
}
