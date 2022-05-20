using System;
using MediatR;
using XLog.Category.Application.UseCases.GetPostalCode;

namespace XLog.Category.Infrastructure.UseCases.GetPostalCode
{
    public class GetPostalCodeCommand : IRequest<GetPostalCodeResponse>, IGetPostalCode
    {
        public string CountryCode {get; set;}
        public string CityCode {get; set;}
        public string DistrictCode {get; set;}
        public string WardCode {get; set;}
    }
}