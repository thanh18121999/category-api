using System;

namespace XLog.Category.Infrastructure.Dto
{
    public class RouteDto
    {
        public RouteDto(string code, string name, string status)
        {
            Code = code;
            Name = name;
            Status = status;
           
        }
        public string? Code { get; set; }
        public string? Name { get; set; }
        public string? Status { get; set; }
    }
}
