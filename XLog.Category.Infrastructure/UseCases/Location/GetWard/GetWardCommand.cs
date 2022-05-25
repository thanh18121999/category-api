using System;
using MediatR;
using XLog.Category.Application.UseCases.GetWard;

namespace XLog.Category.Infrastructure.UseCases.GetWard
{
    public class GetWardCommand : IRequest<GetWardResponse>, IGetWard
    {
        public string WardCode { get; set; }
        public string DistrictCode {get;set;}
        public string CityCode { get; set; }
        public string CountryCode { get; set; }


    }
    public class GetAllWardCommand : IRequest<GetAllWardResponse>, IGetAllWard
    {
        public string DistrictCode {get;set;}
        public string CityCode { get; set; }
        public string CountryCode { get; set; }


    }
}
