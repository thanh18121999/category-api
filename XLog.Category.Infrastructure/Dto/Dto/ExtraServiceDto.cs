using System;

namespace XLog.Category.Infrastructure.Dto
{
    public class ExtraServiceDto
    { 
        public string? Id { get; set; }
        public string? Name { get; set; }
        public string? Description { get; set; }
        public int Active { get; set;}
        public int LevelService { get; set;}
        public string? Note { get; set;}
        public int AllServiceApply { get; set;}   
        public DateTime ApplyFromDate { get; set;}
        public DateTime ApplyToDate { get; set;}
        public string? Code { get; set;} 
    }
}