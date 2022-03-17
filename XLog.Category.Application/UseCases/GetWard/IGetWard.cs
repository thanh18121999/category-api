using System;

namespace XLog.Category.Application.UseCases.GetWard
{
    public interface IGetWard
    {
        public string WardCode {get;}
        public string DistrictCode {get;}
        public string CityCode { get; }
        public string CountryCode { get; }
        
    }

    public interface IGetAllWard
    {
        public string DistrictCode {get;}
        public string CityCode { get; }
        public string CountryCode { get; }
        
    }
}
