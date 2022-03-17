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
            var city = await _cityRepository.GetByCity_Country_Code(command.CityCode, command.CountryCode, cancellationToken);

            var result = new GetCityResponse
            {
                city = _mapper.Map<CITY>(city)
            };

            return result;
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
            var city = await _cityRepository.GetAllByCountryCode(command.CountryCode, cancellationToken);

            var result = new GetAllCityResponse
            {
                cities = _mapper.Map<IEnumerable<CityDto>>(city)
            };

            return result;
        }

         
    }
}
