using System;

namespace XLog.Category.Domain
{
    public class MERCHANDISETYPE: BaseEntity<string?>
    {
        public string ID { get; set; }
        public string? DESCRIPTION { get; set; }
        public string? MERCHANDISEDESCRIPTION { get; set; }
        public int IDSERVICE { get; set; }
        public int ACTIVE { get; set; }
    }
}
