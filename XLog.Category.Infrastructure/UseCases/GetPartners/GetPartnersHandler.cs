using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using AutoMapper;
using MediatR;
using XLog.Category.Infrastructure.Persistence;
using XLog.Category.Application.Persistence;
using XLog.Category.Domain;
using XLog.Category.Infrastructure.Dto;
using XLog.Core.Persistence;

namespace XLog.Category.Infrastructure.UseCases.GetPartners
{
    public class GetPartnersHandler : IRequestHandler<GetPartnersCommand, GetPartnersResponse>
    {
        //private readonly IPartnerRepository _partnerRepository;
        private readonly IRepository<PARTNER> _partnerRepository;
        private readonly IMapper _mapper;

        public GetPartnersHandler(IRepository<PARTNER> partnerRepository, IMapper mapper)
        {
            _partnerRepository = partnerRepository;
            _mapper = mapper;
        }

        public async Task<GetPartnersResponse> Handle(GetPartnersCommand command, CancellationToken cancellationToken)
        {
            var totalOfPartners = await _partnerRepository.CountAsync(cancellationToken);

            var partners = await _partnerRepository.ToListAsync(cancellationToken);

            var result = new GetPartnersResponse
            {
                Partners = _mapper.Map<IEnumerable<PartnerDto>>(partners),
                TotalOfPartners = totalOfPartners
            };

            return result;
        }
    }
}
