using System;

namespace XLog.Category.Domain
{
    public class CURRENCY
    {
        public string ID { get; set; }
        public string? CODE { get; set; }
        public string? NAME { get; set; }
        public float EXCHANGERATE { get; set; }
        public int ISACTIVE { get; set; }
    }
}
