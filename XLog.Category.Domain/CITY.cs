using System;

namespace XLog.Category.Domain
{
    public class CITY
    {
        public string ID { get; set; }

        public string CODE { get; set; }
        public string? NAME { get; set; }
        public string COUNTRYID { get; set; }
        public COUNTRY COUNTRY { get; set; }
        public int ISACTIVE { get; set; }
    }
}
