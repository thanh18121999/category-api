using System;

namespace XLog.Category.Infrastructure.Dto
{
    public class TransportTypeDto
    {
        public TransportTypeDto(string code, string name, int totalweight, int volume, int status)
        {
            Code = code;
            Name = name;
            TotalWeight = totalweight;
            Volume = volume;
            Status = status;
           
        }
        public string? Code { get; set; }
        public string? Name { get; set; }
        public int TotalWeight { get; set; }
        public int Volume { get; set; }
        public int Status { get; set; }
    }
}
