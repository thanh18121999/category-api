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
using XLog.Category.Infrastructure.UseCases.AddPartner;

namespace XLog.Category.Infrastructure.UseCases.AddPartner
{
    public class AddPartnerHandler : IRequestHandler<AddPartnerCommand, AddPartnerResponse>
    {
        private readonly IPartnerRepository _partnerRepository;
        private readonly IMapper _mapper;

        public AddPartnerHandler(IPartnerRepository partnerRepository, IMapper mapper)
        {
            _partnerRepository = partnerRepository;
            _mapper = mapper;
        }

        public async Task<AddPartnerResponse> Handle(AddPartnerCommand command, CancellationToken cancellationToken)
        {
            try {
                var responses = _mapper.Map<PARTNER>(command);

                await _partnerRepository.AddAsync(responses, cancellationToken);
                await _partnerRepository.SaveChangesAsync(cancellationToken);
                return new AddPartnerResponse
                {
                    StatusCode = System.Net.HttpStatusCode.OK,
                    message = "Success",
                };
            }
            catch {
                return new AddPartnerResponse
                {
                    StatusCode = System.Net.HttpStatusCode.InternalServerError,
                    message = "Error",
                };
            }
        }
    }
}
