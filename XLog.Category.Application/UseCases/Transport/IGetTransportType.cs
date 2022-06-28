using System;
using System.Collections.Generic;

namespace XLog.Category.Application.UseCases.GetTransportType
{
    public interface IGetAllTransportType
    {
        
    }
    public class AddTransportTypeItem
    {
        public string? Id { get; set; }
        public string? Code { get; set; }
        public string? Name { get; set;}
        public string? Note { get; set;}
        public string? Status { get; set;}
    }
    public interface ICreateTransportType
    {
        public IEnumerable<AddTransportTypeItem> transportTypeItems {get;}
    }
    public class UpdateTransportTypeItem
    {
        public string? Id { get; set; }
        public string? Code { get; set; }
        public string? Name { get; set;}
        public string? Note { get; set;}
        public string? Status { get; set;}
    }
        
    public interface IUpdateTransportType
    {
        public IEnumerable<UpdateTransportTypeItem> transportTypes {get;}
    }
    public interface IDeleteTransportType
    {
        public string ID { get; }
    }
}
