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
            try {
                var country = await _countryRepository.GetById(command.CountryId, cancellationToken);

                return new GetCountryResponse
                {
                    StatusCode = System.Net.HttpStatusCode.OK,
                    message = "Success",
                    responses = _mapper.Map<COUNTRY>(country)
                };
            }
            catch {
                return new GetCountryResponse
                {
                    StatusCode = System.Net.HttpStatusCode.InternalServerError,
                    message = "Error",
                }; 
            }
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
            try {
                var country = await _countryRepository.GetByCode(command.CountryCode, cancellationToken);

                return new GetCountryResponse
                {
                    StatusCode = System.Net.HttpStatusCode.OK,
                    message = "Success",
                    responses = _mapper.Map<COUNTRY>(country)
                };
            }
            catch {
                return new GetCountryResponse
                {
                    StatusCode = System.Net.HttpStatusCode.InternalServerError,
                    message = "Error",
                };
            }
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
            try {
                var country = await _countryRepository.GetAll(cancellationToken);

                return new GetAllCountryResponse
                {
                    StatusCode = System.Net.HttpStatusCode.OK,
                    message = "Success",
                    responses = _mapper.Map<IEnumerable<CountryDto>>(country),
                };
            }
            catch {
                return new GetAllCountryResponse
                {
                    StatusCode = System.Net.HttpStatusCode.InternalServerError,
                    message = "Error",

                };
            }
        }

    }
}


