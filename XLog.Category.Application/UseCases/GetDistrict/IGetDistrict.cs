using System;

namespace XLog.Category.Application.UseCases.GetDistrict
{
    public interface IGetDistrict
    {
        public string DistrictCode {get;}
        public string CityCode { get; }
        public string CountryCode { get; }
        
    }

    public interface IGetAllDistrict
    {
        public string CityCode { get; }
        public string CountryCode { get; }
        
    }
}
