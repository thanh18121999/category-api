using System;

namespace XLog.Category.Infrastructure.Dto
{
    public class DeliveryMethodDto
    {
        public DeliveryMethodDto(string code, string name, string note, string status)
        {
            Code = code;
            Name = name;
            Note = note;
            Status = status;
           
        }
        public string? Code { get; set; }
        public string? Name { get; set; }
        public string? Note { get; set; }
        public string? Status { get; set; }
    }
}
