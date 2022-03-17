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
            var partner = await _partnerRepository.GetAsync(command.PartnerId, cancellationToken);

            var result = new GetPartnerResponse
            {
                Partner = _mapper.Map<PARTNER>(partner)
            };

            return result;
        }
    }
}
