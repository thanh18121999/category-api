using System;
using System.Collections.Generic;

namespace XLog.Category.Application.UseCases.GetRoute
{
    public interface IGetAllRoute
    {
        
    }
    public class AddRouteItem
    {
        public string? Id { get; set; }
        public string? Code { get; set; }
        public string? Name { get; set;}
        public string? Note { get; set;}
        public string? Status { get; set;}
    }
    public interface ICreateRoute
    {
        public IEnumerable<AddRouteItem> routeItems {get;}
    }
    public class UpdateRouteItem
    {
        public string? Id { get; set; }
        public string? Code { get; set; }
        public string? Name { get; set;}
        public string? Note { get; set;}
        public string? Status { get; set;}
    }
        
    public interface IUpdateRoute
    {
        public IEnumerable<UpdateRouteItem> routes {get;}
    }
    public interface IDeleteRoute
    {
        public string ID { get; }
    }
}
