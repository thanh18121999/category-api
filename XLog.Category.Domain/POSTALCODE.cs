using System;

namespace XLog.Category.Domain
{
    public class POSTALCODE
    {
        public string ID { get; set; }
        public string? CODE { get; set; }
        public string COUNTRYID { get; set; }
        public COUNTRY COUNTRY { get; set; }
    }
}
