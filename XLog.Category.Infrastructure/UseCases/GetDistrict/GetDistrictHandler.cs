using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using AutoMapper;
using AutoMapper.QueryableExtensions;
using MediatR;
using XLog.Category.Application.Persistence;
using XLog.Category.Domain;
using XLog.Category.Infrastructure.Dto;
using XLog.Category.Infrastructure.Persistence;
//using XLog.Category.Infrastructure.UseCases.GetPartner;

namespace XLog.Category.Infrastructure.UseCases.GetDistrict
{
    public class GetDistrictHandler : IRequestHandler<GetDistrictCommand, GetDistrictResponse>
    {
        private readonly IDistrictRepository _districtRepository;
        private readonly IMapper _mapper;

        private readonly ICityRepository _cityRepository;

        public GetDistrictHandler(IDistrictRepository DistrictRepository, IMapper mapper, ICityRepository cityRepository)
        {
            _districtRepository = DistrictRepository;
            _mapper = mapper;
            _cityRepository = cityRepository;
        }

        public async Task<GetDistrictResponse> Handle(GetDistrictCommand command, CancellationToken cancellationToken)
        {
            try { 
                var _district = await _districtRepository.GetByDistrict_City_Country_Code(command.DistrictCode,command.CityCode,command.CountryCode,cancellationToken);

                return new GetDistrictResponse
                {
                    StatusCode = System.Net.HttpStatusCode.OK,
                    message = "Success",
                    responses = _mapper.Map<IEnumerable<DISTRICTS>>(_district)
                };
            }
            catch { 
                return new GetDistrictResponse
                {
                    StatusCode = System.Net.HttpStatusCode.InternalServerError,
                    message = "Error",
                };
            }
        }
    }
    public class GetAllDistrictHandler : IRequestHandler<GetAllDistrictCommand, GetAllDistrictResponse>
    {
        private readonly IDistrictRepository _districtRepository;
        private readonly IMapper _mapper;

        private readonly ICityRepository _cityRepository;

        public GetAllDistrictHandler(IDistrictRepository DistrictRepository, IMapper mapper, ICityRepository cityRepository)
        {
            _districtRepository = DistrictRepository;
            _mapper = mapper;
            _cityRepository = cityRepository;
        }

        public async Task<GetAllDistrictResponse> Handle(GetAllDistrictCommand command, CancellationToken cancellationToken)
        {
            try {
                var _districts = await _districtRepository.GetAllByCity_CountryCode(command.CityCode,command.CountryCode,cancellationToken);

                return new GetAllDistrictResponse
                {
                    StatusCode = System.Net.HttpStatusCode.OK,
                    message = "Success",
                    responses = _mapper.Map<IEnumerable<DISTRICTS>>(_districts)
                };
            }
            catch {
                return new GetAllDistrictResponse
                {
                    StatusCode = System.Net.HttpStatusCode.InternalServerError,
                    message = "Error",
                }; 
            }
        }
    }
}