using System;
using MediatR;
using XLog.Category.Application.UseCases.GetDeliveryMethod;
using XLog.Category.Infrastructure.Dto;
using System.Collections.Generic;
using XLog.Category.Domain;

namespace XLog.Category.Infrastructure.UseCases.UpdateDeliveryMethod
{
    public class UpdateDeliveryMethodCommand : IRequest<UpdateDeliveryMethodResponse>, IUpdateDeliveryMethod
    {
        public IEnumerable<UpdateDeliveryMethodItem> deliveryMethods {get;set;}
    }
}
