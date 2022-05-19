using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using AutoMapper;
using AutoMapper.QueryableExtensions;
using MediatR;
using XLog.Category.Application.Persistence;
using XLog.Category.Domain;
using XLog.Category.Infrastructure.Dto;
//using XLog.Category.Infrastructure.Dto;
using XLog.Category.Infrastructure.Persistence;
using XLog.Category.Infrastructure.UseCases.GetPartner;

namespace XLog.Category.Infrastructure.UseCases.GetPartner
{
    public class GetPartnerHandler : IRequestHandler<GetPartnerCommand, GetPartnerResponse>
    {
        private readonly IPartnerRepository _partnerRepository;
        private readonly IMapper _mapper;

        public GetPartnerHandler(IPartnerRepository partnerRepository, IMapper mapper)
        {
            _partnerRepository = partnerRepository;
            _mapper = mapper;
        }

        public async Task<GetPartnerResponse> Handle(GetPartnerCommand command, CancellationToken cancellationToken)
        {
            try {
                var responses = await _partnerRepository.GetAsync(command.PartnerId, cancellationToken);

                return new GetPartnerResponse
                {
                    StatusCode = System.Net.HttpStatusCode.OK,
                    message = "Success",
                    responses = _mapper.Map<PARTNER>(responses)
                };
            }
            catch {
                return new GetPartnerResponse
                {
                    StatusCode = System.Net.HttpStatusCode.InternalServerError,
                    message = "Error",
                };
            }
            
        }
    }
}
