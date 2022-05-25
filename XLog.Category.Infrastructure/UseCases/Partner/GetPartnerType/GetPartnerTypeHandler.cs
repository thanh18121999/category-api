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

namespace XLog.Category.Infrastructure.UseCases.GetPartnerType
{
    public class GetPartnerTypeHandler : IRequestHandler<GetPartnerTypeCommand, GetPartnerTypeResponse>
    {
        private readonly IPartnerTypeRepository _partnerTypeRepository;
        private readonly IMapper _mapper;

        public GetPartnerTypeHandler(IPartnerTypeRepository partnerTypeRepository, IMapper mapper)
        {
            _partnerTypeRepository = partnerTypeRepository;
            _mapper = mapper;
        }

        public async Task<GetPartnerTypeResponse> Handle(GetPartnerTypeCommand command, CancellationToken cancellationToken)
        {
            try {
                var responses = await _partnerTypeRepository.GetPartnerType(command.PartnerTypeID, cancellationToken);

                return new GetPartnerTypeResponse
                {
                    StatusCode = System.Net.HttpStatusCode.OK,
                    message = "Success",
                    responses = _mapper.Map<PARTNERTYPE>(responses)
                };
            }
            catch {
                return new GetPartnerTypeResponse
                {
                    StatusCode = System.Net.HttpStatusCode.InternalServerError,
                    message = "Error",
                };
            }
        }  
    }
}


