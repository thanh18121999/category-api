using System;
using MediatR;
using XLog.Category.Application.UseCases.GetCity;

namespace XLog.Category.Infrastructure.UseCases.GetCity
{
    public class GetCityCommand : IRequest<GetCityResponse>, IGetCity
    {
        public string CityCode { get; set; }
        public string CountryCode { get; set; }

    }
    public class GetAllCityByCountryCodeCommand : IRequest<GetAllCityResponse>, IGetAllCity
    {
        public string CountryCode{ get; set; } 
    }
}
