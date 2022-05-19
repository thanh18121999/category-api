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

namespace XLog.Category.Infrastructure.UseCases.GetWard
{
    public class GetWardHandler : IRequestHandler<GetWardCommand, GetWardResponse>
    {
        private readonly IWardRepository _WardRepository;
        private readonly IMapper _mapper;

        private readonly IDistrictRepository _districtRepository;

        public GetWardHandler(IWardRepository WardRepository, IMapper mapper, IDistrictRepository districtRepository)
        {
            _WardRepository = WardRepository;
            _mapper = mapper;
            _districtRepository = districtRepository;
        }

        public async Task<GetWardResponse> Handle(GetWardCommand command, CancellationToken cancellationToken)
        {
            try {
                var _responses = await _WardRepository.GetByWard_District_City_Country_Code(command.WardCode,command.DistrictCode,command.CityCode,command.CountryCode,cancellationToken);

                return new GetWardResponse
                {
                    StatusCode = System.Net.HttpStatusCode.OK,
                    message = "Success",
                    responses = _mapper.Map<IEnumerable<WARDS>>(_responses)
                };
            }
            catch {
                return new GetWardResponse
                {
                    StatusCode = System.Net.HttpStatusCode.InternalServerError,
                    message = "Error",
                };
            }
        }
    }
    public class GetAllWardHandler : IRequestHandler<GetAllWardCommand, GetAllWardResponse>
    {
        private readonly IWardRepository _WardRepository;
        private readonly IMapper _mapper;

        private readonly IDistrictRepository _districtRepository;

        public GetAllWardHandler(IWardRepository WardRepository, IMapper mapper, IDistrictRepository districtRepository)
        {
            _WardRepository = WardRepository;
            _mapper = mapper;
            _districtRepository = districtRepository;
        }

        public async Task<GetAllWardResponse> Handle(GetAllWardCommand command, CancellationToken cancellationToken)
        {
            try {
                var _responses = await _WardRepository.GetAllByDistrict_City_CountryCode(command.DistrictCode,command.CityCode,command.CountryCode,cancellationToken);

                return new GetAllWardResponse
                {
                    StatusCode = System.Net.HttpStatusCode.OK,
                    message = "Success",
                    responses = _mapper.Map<IEnumerable<WARDS>>(_responses)
                };
            }
            catch {
                return new GetAllWardResponse
                {
                    StatusCode = System.Net.HttpStatusCode.InternalServerError,
                    message = "Error",
                };
            }
        }
    }
}