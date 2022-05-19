using System;

namespace XLog.Category.Domain
{
    public class EXTRASERVICE
    {
        public string ID { get; set; }
        public string NAME { get; set; }
        public string DESCRIPTION { get; set; }
        public int ACTIVE { get; set; }
        public string PARENTID { get; set; }
        public int LEVELSERVICE { get; set; }
        public string NOTE { get; set; }
        public int ALLSERVICEAPPLY { get; set; }
        public DateTime APPLYFROMDATE { get; set; }
        public DateTime APPLYTODATE { get; set; }
    }
}