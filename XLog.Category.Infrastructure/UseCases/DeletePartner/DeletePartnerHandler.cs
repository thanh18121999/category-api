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
using XLog.Category.Infrastructure.UseCases.DeletePartner;

namespace XLog.Category.Infrastructure.UseCases.DeletePartner
{
    public class DeletePartnersHandler : IRequestHandler<DeletePartnerCommand, bool>
    {
        private readonly IPartnerRepository _partnerRepository;
        private readonly IMapper _mapper;

        public DeletePartnersHandler(IPartnerRepository partnerRepository, IMapper mapper)
        {
            _partnerRepository = partnerRepository;
            _mapper = mapper;
        }

        public async Task<bool> Handle(DeletePartnerCommand command, CancellationToken cancellationToken)
        {
            _partnerRepository.Remove(new PARTNER { ID = command.PartnerId });

            var result = await _partnerRepository.SaveChangesAsync(cancellationToken);

            return result > 0;
        }
    }
}
