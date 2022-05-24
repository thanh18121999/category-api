using System;

namespace XLog.Category.Domain
{
    public class PARTNERS: BaseEntity<string?>
    {
        public string ID { get; set; }
        public string? ACCOUNT { get; set; }
        public string? PASSWORD { get; set; }
        public string? REMEMBERCODE { get; set; }
        public string? NAME { get; set; }
        public string? FULLNAME { get; set; }
        public string? PHONE { get; set; }
        public string? EMAIL { get; set; }
        public string? ADDRESS { get; set; }
        public string IDPARTNER { get; set; }
        public string COUNTRYCODE { get; set; }
        public string CITYCODE { get; set; }
        public string DISTRICTCODE { get; set; }
        public string WARDCODE { get; set; }
        public string POSTALCODE { get; set; }        
        public string? CONTACT { get; set; }
        public string? PHONECONTACT { get; set; }
        public string IDCREATOR { get; set; }
        public string IDUPDATOR { get; set; }
        public DateTime CREATEDTIME { get; set; }
        public DateTime UPDATEDTIME { get; set; }
        public DateTime SYSTEMTIME { get; set; }
        public int ISACTIVE { get; set; }
    }
    
}
