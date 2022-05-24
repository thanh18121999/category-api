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
        private readonly IRepository<PARTNERS> _partnerRepository;
        private readonly IMapper _mapper;

        public GetPartnersHandler(IRepository<PARTNERS> partnerRepository, IMapper mapper)
        {
            _partnerRepository = partnerRepository;
            _mapper = mapper;
        }

        public async Task<GetPartnersResponse> Handle(GetPartnersCommand command, CancellationToken cancellationToken)
        {
            try { 
                var totalOfPartners = await _partnerRepository.CountAsync(cancellationToken);

                var responses = await _partnerRepository.ToListAsync(cancellationToken);

                return new GetPartnersResponse
                {
                    StatusCode = System.Net.HttpStatusCode.OK,
                    message = "Success",
                    responses = _mapper.Map<IEnumerable<PartnerDto>>(responses),
                    TotalOfPartners = totalOfPartners
                };
            }
            catch { 
                return new GetPartnersResponse
                {
                    StatusCode = System.Net.HttpStatusCode.InternalServerError,
                    message = "Error",
                };
            }
        }
    }
}
