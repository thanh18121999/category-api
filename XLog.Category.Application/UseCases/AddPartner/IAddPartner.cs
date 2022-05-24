using System;
using System.Collections.Generic;

namespace XLog.Category.Application.UseCases.AddPartner
{
    // public interface IAddPartner
    // {
    //     public string Id { get; set; }
    //     public string Account { get; set; }
    //     public string Password { get; set; }
    //     public string RememberCode { get; set; }
    //     public string Name { get; set; }
    //     public string Fullname { get; set; }
    //     public string Phone { get; set; }
    //     public string Email { get; set; }
    //     public string Address { get; set; }
    //     public string IDPartner { get; set; }
    //     public string CountryCode { get; set; }
    //     public string CityCode { get; set; }
    //     public string DistrictCode { get; set; }
    //     public string WardCode { get; set; }
    //     public string Postalcode { get; set; }
    //     public string Contact { get; set; }
    //     public string PhoneContact { get; set; }
    //     public string IsActive { get; set; }
    //     public string IDCreator { get; set; }
    //     public string IDUpdator { get; set; }
    //     public DateTime CreatedTime { get; set; }
    //     public DateTime UpdatedTime { get; set; }
    //     public DateTime SystemTime { get; set; }
    // }
    public class AddPartnerItem
    {
        public string Id { get; set; }
        public string Account { get; set; }
        public string Password { get; set; }
        public string RememberCode { get; set; }
        public string Name { get; set; }
        public string Fullname { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
        public string Address { get; set; }
        public string IDPartner { get; set; }
        public string CountryCode { get; set; }
        public string CityCode { get; set; }
        public string DistrictCode { get; set; }
        public string WardCode { get; set; }
        public string Postalcode { get; set; }
        public string Contact { get; set; }
        public string PhoneContact { get; set; }
        public int IsActive { get; set; }
        public string IDCreator { get; set; }
        public string IDUpdator { get; set; }
        public DateTime CreatedTime { get; set; }
        public DateTime UpdatedTime { get; set; }
        public DateTime SystemTime { get; set; }
    }
    public interface ICreatePartner
    {
        public IEnumerable<AddPartnerItem> PartnerItems {get;}
    }
}
