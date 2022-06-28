using System;
using System.Collections.Generic;

namespace XLog.Category.Application.UseCases.GetExtraService
{
    public interface IGetExtraService
    {
        public string ExtraServiceID { get; }
    }
    public class AddExtraServiceItem
    {
        public string? Id { get; set; }
        public string? Name { get; set; }
        public string? Description { get; set; }
        public int Active { get; set;}
        public string? ParentID { get; set;}
        public int LevelService { get; set;}
        public string? Note { get; set;}
        public int AllServiceApply { get; set;}   
        public DateTime ApplyFromDate { get; set;}
        public DateTime ApplyToDate { get; set;}
        public string? Code { get; set;}
    }
    public interface ICreateExtraService
    {
        public IEnumerable<AddExtraServiceItem> extraServiceItems {get;}
    }
    public class UpdateExtraServiceItem
    {
        public string? Id { get; set; }
        public string? Name { get; set; }
        public string? Description { get; set; }
        public int Active { get; set;}
        public string? ParentID { get; set;}
        public int LevelService { get; set;}
        public string? Note { get; set;}
        public int AllServiceApply { get; set;}   
        public DateTime ApplyFromDate { get; set;}
        public DateTime ApplyToDate { get; set;}
        public string? Code { get; set;} 
    }
    public interface IUpdateExtraService
    {
        public IEnumerable<UpdateExtraServiceItem> extraServices {get;}
    }
    public interface IDeleteExtraService
    {
        public string extraServiceID { get; }
    }
}