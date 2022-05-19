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

namespace XLog.Category.Infrastructure.UseCases.GetCity
{
    public class GetCityHandler : IRequestHandler<GetCityCommand, GetCityResponse>
    {
        private readonly ICityRepository _cityRepository;
        private readonly IMapper _mapper;

        public GetCityHandler(ICityRepository cityRepository, IMapper mapper)
        {
            _cityRepository = cityRepository;
            _mapper = mapper;
        }

        public async Task<GetCityResponse> Handle(GetCityCommand command, CancellationToken cancellationToken)
        {
            try {
                var citycode = await _cityRepository.GetByCity_Country_Code(command.CityCode, command.CountryCode, cancellationToken);

                return new GetCityResponse
                {
                    StatusCode = System.Net.HttpStatusCode.OK,
                    message = "Success",
                    responses = _mapper.Map<IEnumerable<PROVINCES>>(citycode)
                };
            }
            catch {
                return new GetCityResponse
                {
                    StatusCode = System.Net.HttpStatusCode.InternalServerError,
                    message = "Error",
                };
            }
        }
    }

    public class GetAllCityHandler : IRequestHandler<GetAllCityByCountryCodeCommand, GetAllCityResponse>
    {
        private readonly ICityRepository _cityRepository;
        private readonly IMapper _mapper;

        public GetAllCityHandler(ICityRepository cityRepository, IMapper mapper)
        {
            _cityRepository = cityRepository;
            _mapper = mapper;
        }

        public async Task<GetAllCityResponse> Handle(GetAllCityByCountryCodeCommand command, CancellationToken cancellationToken)
        {
            try {
                var cities = await _cityRepository.GetAllByCountryCode(command.CountryCode, cancellationToken);

                return new GetAllCityResponse
                {
                    StatusCode = System.Net.HttpStatusCode.OK,
                    message = "Success",
                    responses = _mapper.Map<IEnumerable<PROVINCES>>(cities)
                };
            }
            catch {
                return new GetAllCityResponse
                {
                    StatusCode = System.Net.HttpStatusCode.InternalServerError,
                    message = "Error",
                };
            }
        }

         
    }
}
