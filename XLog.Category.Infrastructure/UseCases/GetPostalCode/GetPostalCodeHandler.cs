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

namespace XLog.Category.Infrastructure.UseCases.GetPostalCode
{
    public class GetPostalCodeHandler : IRequestHandler<GetPostalCodeCommand,GetPostalCodeResponse>
    {
        private readonly IPostalCodeRepository _postalCodeRepository;
        private readonly IMapper _mapper;
         public GetPostalCodeHandler(IPostalCodeRepository PostalCodeRepository, IMapper mapper)
        {
            _postalCodeRepository = PostalCodeRepository;
            _mapper = mapper;
        }
        public async Task<GetPostalCodeResponse> Handle(GetPostalCodeCommand command, CancellationToken cancellationToken)
        {
            try {
                    var _postalCode = await _postalCodeRepository.GetByCountry_City_District_Ward_Code(command.CountryCode,command.CityCode,command.DistrictCode,command.WardCode,cancellationToken);

                    return new GetPostalCodeResponse
                    {
                        StatusCode = System.Net.HttpStatusCode.OK,
                        message = "Success",
                        responses = _mapper.Map<IEnumerable<PostalCodeDto>>(_postalCode)
                    };
                }
            catch {
                    return new GetPostalCodeResponse
                    {
                        StatusCode = System.Net.HttpStatusCode.InternalServerError,
                        message = "Error",
                    }; 
                }
        }
    }
}