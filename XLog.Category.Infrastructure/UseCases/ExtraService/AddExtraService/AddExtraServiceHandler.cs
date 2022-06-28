using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using AutoMapper;
using MediatR;
using XLog.Category.Application.Persistence;
using XLog.Category.Application.UseCases.GetExtraService;

namespace XLog.Category.Infrastructure.UseCases.AddExtraService
{
    public class AddExtraServiceHandler : IRequestHandler<AddExtraServiceCommand, AddExtraServiceResponse>
    {
        private readonly IExtraServiceRepository _extraServiceRepository;
        private readonly IMapper _mapper;

        public AddExtraServiceHandler(IExtraServiceRepository extraServiceRepository, IMapper mapper)
        {
            _extraServiceRepository = extraServiceRepository;
            _mapper = mapper;
        }

        public async Task<AddExtraServiceResponse> Handle(AddExtraServiceCommand command, CancellationToken cancellationToken)
        {
            try {
                List<Domain.EXTRASERVICE> AddedExtraServices = new List<Domain.EXTRASERVICE>();
                foreach (AddExtraServiceItem extraserviceItem in command.extraServiceItems)
                {
                    Domain.EXTRASERVICE extraservice = _mapper.Map<Domain.EXTRASERVICE>(extraserviceItem);
                    await _extraServiceRepository.AddAsync(extraservice, cancellationToken);  
                    AddedExtraServices.Add(extraservice);               
                }
                await _extraServiceRepository.SaveChangesAsync(cancellationToken);
                return new AddExtraServiceResponse
                {
                    StatusCode = System.Net.HttpStatusCode.OK,
                    message = "Success",
                };
            }
            catch {
                return new AddExtraServiceResponse
                {
                    StatusCode = System.Net.HttpStatusCode.InternalServerError,
                    message = "Error",
                }; 
            }
        }
    }
}
