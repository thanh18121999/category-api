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
    public class AddPartnerHandler : IRequestHandler<AddPartnerCommand, PartnerDto>
    {
        private readonly IPartnerRepository _partnerRepository;
        private readonly IMapper _mapper;

        public AddPartnerHandler(IPartnerRepository partnerRepository, IMapper mapper)
        {
            _partnerRepository = partnerRepository;
            _mapper = mapper;
        }

        public async Task<PartnerDto> Handle(AddPartnerCommand command, CancellationToken cancellationToken)
        {
            var itemFromCommand = _mapper.Map<PARTNER>(command);

            await _partnerRepository.AddAsync(itemFromCommand, cancellationToken);
            await _partnerRepository.SaveChangesAsync(cancellationToken);

            return _mapper.Map<PartnerDto>(itemFromCommand);
        }
    }
}
