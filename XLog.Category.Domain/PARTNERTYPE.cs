using System;

namespace XLog.Category.Domain
{
    public class PARTNERTYPE: BaseEntity<string?>
    {
        public string ID { get; set; }
        public string? DESCRIPTION { get; set; }
        public string? DETAILDESCRIPTION { get; set; }
    }
}
