using System;
using System.Collections.Generic;

namespace XLog.Category.Application.UseCases.GetDeliveryMethod
{
    public interface IGetAllDeliveryMethod
    {
        
    }
    public class AddDeliveryMethodItem
    {
        public string? Id { get; set; }
        public string? Code { get; set; }
        public string? Name { get; set;}
        public string? Note { get; set;}
        public string? Status { get; set;}
    }
    public interface ICreateDeliveryMethod
    {
        public IEnumerable<AddDeliveryMethodItem> deliveryMethodItems {get;}
    }
    public class UpdateDeliveryMethodItem
    {
        public string? Id { get; set; }
        public string? Code { get; set; }
        public string? Name { get; set;}
        public string? Note { get; set;}
        public string? Status { get; set;}
    }
        
    public interface IUpdateDeliveryMethod
    {
        public IEnumerable<UpdateDeliveryMethodItem> deliveryMethods {get;}
    }
    public interface IDeleteDeliveryMethod
    {
        public string ID { get; }
    }
}
