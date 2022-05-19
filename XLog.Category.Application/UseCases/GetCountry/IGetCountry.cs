using System;

namespace XLog.Category.Application.UseCases.GetCountry
{
    public interface IGetCountryById
    {
        public int CountryId { get; }

    }

    public interface IGetCountryByCode
    {
        public string CountryCode { get; }

    }

    
}
