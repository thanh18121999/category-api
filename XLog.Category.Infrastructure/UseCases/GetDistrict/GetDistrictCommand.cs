using System;
using MediatR;
using XLog.Category.Application.UseCases.GetDistrict;

namespace XLog.Category.Infrastructure.UseCases.GetDistrict
{
    public class GetDistrictCommand : IRequest<GetDistrictResponse>, IGetDistrict
    {
        public string DistrictCode { get; set; }
        public string CityCode { get; set; }
        public string CountryCode { get; set; }


    }
    public class GetAllDistrictCommand : IRequest<GetAllDistrictResponse>, IGetAllDistrict
    {
        public string CityCode { get; set; }
        public string CountryCode { get; set; }


    }
}
