using System;

namespace XLog.Category.Application.UseCases.GetPostalCode
{
    public interface IGetPostalCode
    {
        public string CountryCode {get;}
        public string CityCode {get;}
        public string DistrictCode {get;}
        public string WardCode {get;}
    }

    public interface IGetInfoByPostalCode
    {
        public string PostalCode {get;}
        
    }

}
