using System;
using MediatR;
using XLog.Category.Application.UseCases.GetDeliveryMethod;
using XLog.Category.Infrastructure.Dto;
using System.Collections.Generic;
using XLog.Category.Domain;

namespace XLog.Category.Infrastructure.UseCases.AddDeliveryMethod
{
    public class AddDeliveryMethodCommand : IRequest<AddDeliveryMethodResponse>, ICreateDeliveryMethod
    {
        public IEnumerable<AddDeliveryMethodItem> deliveryMethodItems {get;set;}
    }
}
