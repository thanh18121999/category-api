using System;

namespace XLog.Category.Application.UseCases.AddPartner
{
    public interface IAddPartner
    {
        public string Id { get; }
        public string Account { get; }
        public string Password { get; }
        public string RememberCode { get; }
        public string Name { get; }
        public string Fullname { get; }
        public string Phone { get; }
        public string Email { get; }
        public string Address { get; }
        public string IDPartner { get; }
        public string CountryCode { get; }
        public string CityCode { get; }
        public string DistrictCode { get; }
        public string WardCode { get; }
        public string Postalcode { get; }
        public string Contact { get; }
        public string PhoneContact { get; }
        public string IsActive { get; }
        public string IDCreator { get; }
        public string IDUpdator { get; }
        public DateTime CreatedTime { get; }
        public DateTime UpdatedTime { get; }
        public DateTime SystemTime { get; }
    }
}
