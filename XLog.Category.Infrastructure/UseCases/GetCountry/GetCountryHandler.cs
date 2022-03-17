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

namespace XLog.Category.Infrastructure.UseCases.GetCountry
{
    public class GetCountryByIdHandler : IRequestHandler<GetCountryByIdCommand, GetCountryResponse>
    {
        private readonly ICountryRepository _countryRepository;
        private readonly IMapper _mapper;

        public GetCountryByIdHandler(ICountryRepository countryRepository, IMapper mapper)
        {
            _countryRepository = countryRepository;
            _mapper = mapper;
        }

        public async Task<GetCountryResponse> Handle(GetCountryByIdCommand command, CancellationToken cancellationToken)
        {
            var country = await _countryRepository.GetById(command.CountryId, cancellationToken);

            var result = new GetCountryResponse
            {
                country = _mapper.Map<COUNTRY>(country)
            };

            return result;
        }  
    }

    public class GetCountryByCodeHandler : IRequestHandler<GetCountryByCodeCommand, GetCountryResponse>
    {
        private readonly ICountryRepository _countryRepository;
        private readonly IMapper _mapper;

        public GetCountryByCodeHandler(ICountryRepository countryRepository, IMapper mapper)
        {
            _countryRepository = countryRepository;
            _mapper = mapper;
        }

        public async Task<GetCountryResponse> Handle(GetCountryByCodeCommand command, CancellationToken cancellationToken)
        {
            var country = await _countryRepository.GetByCode(command.CountryCode, cancellationToken);

            var result = new GetCountryResponse
            {
                country = _mapper.Map<COUNTRY>(country)
            };

            return result;
        }

    }
    public class GetAllCountryHandler : IRequestHandler<GetAllCountryCommand, GetAllCountryResponse>
    {
        private readonly ICountryRepository _countryRepository;
        private readonly IMapper _mapper;

        public GetAllCountryHandler(ICountryRepository countryRepository, IMapper mapper)
        {
            _countryRepository = countryRepository;
            _mapper = mapper;
        }

        public async Task<GetAllCountryResponse> Handle(GetAllCountryCommand command, CancellationToken cancellationToken)
        {
            var country = await _countryRepository.GetAll(cancellationToken);

            var result = new GetAllCountryResponse
            {
                countries = _mapper.Map<IEnumerable<CountryDto>>(country),

            };

            return result;
        }

    }
}


