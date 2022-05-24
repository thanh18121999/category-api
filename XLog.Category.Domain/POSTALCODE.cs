using System;

namespace XLog.Category.Domain
{
    public class POSTALCODE
    {
        public int ID { get; set; }
        public string? CODE { get; set; }
        public int STATUS { get; set; }
        public int COUNTRYID { get; set; }
        public int PROVINCEID { get; set; }
        public int DISTRICTID { get; set; }
        public int WARDID { get; set; }
    }
}