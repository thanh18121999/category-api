using System;

namespace XLog.Category.Application.UseCases.GetCity
{
    public interface IGetCity
    {
        public string CountryCode { get; }
        public string CityCode { get; }
        
    }

    public interface IGetAllCity
    {
        public string CountryCode { get; }
        
    }
}
