using System;

namespace XLog.Category.Domain
{
    public class DISTRICT
    {
        public string ID { get; set; }

        public string CODE { get; set; }
        public string? NAME { get; set; }
        public string CITYID { get; set; }
        public CITY CITY { get; set; }
        public int ISACTIIVE { get; set; }
    }
}
