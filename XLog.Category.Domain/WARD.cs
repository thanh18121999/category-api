using System;

namespace XLog.Category.Domain
{
    public class Ward
    {
        public string ID { get; set; }

        public string Code { get; set; }
        public string? WardtName { get; set; }
        public string DISTRICTID { get; set; }
        public DISTRICT DISTRICT { get; set; }
        public int IsActive { get; set; }
    }
}
