using System;

namespace XLog.Category.Application.UseCases.GetCountry
{
    public interface IGetCountryById
    {
        public string CountryId { get; }

    }

    public interface IGetCountryByCode
    {
        public string CountryCode { get; }

    }

    
}
