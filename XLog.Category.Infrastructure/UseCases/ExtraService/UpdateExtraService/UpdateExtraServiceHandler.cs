using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using AutoMapper;
using MediatR;
using XLog.Category.Application.Persistence;
using XLog.Category.Application.UseCases.GetExtraService;

namespace XLog.Category.Infrastructure.UseCases.UpdateExtraService
{
    public class UpdateExtraServiceHandler : IRequestHandler<UpdateExtraServiceCommand, UpdateExtraServiceResponse>
    {
        private readonly IExtraServiceRepository _extraServiceRepository;
        private readonly IMapper _mapper;

        public UpdateExtraServiceHandler(IExtraServiceRepository extraServiceRepository, IMapper mapper)
        {
            _extraServiceRepository = extraServiceRepository;
            _mapper = mapper;
        }

        public async Task<UpdateExtraServiceResponse> Handle(UpdateExtraServiceCommand command, CancellationToken cancellationToken)
        {
            try {
                List<Domain.EXTRASERVICE> UpdatedExtraServices = new List<Domain.EXTRASERVICE>();
                foreach (UpdateExtraServiceItem extraserviceItem in command.extraServices)
                {
                    Domain.EXTRASERVICE extraservice = _mapper.Map<Domain.EXTRASERVICE>(extraserviceItem);
                    _extraServiceRepository.Update(extraservice);  
                    UpdatedExtraServices.Add(extraservice);               
                }
                await _extraServiceRepository.SaveChangesAsync(cancellationToken);
                return new UpdateExtraServiceResponse
                {
                    StatusCode = System.Net.HttpStatusCode.OK,
                    message = "Success",
                };
            }
            catch {
                return new UpdateExtraServiceResponse
                {
                    StatusCode = System.Net.HttpStatusCode.InternalServerError,
                    message = "Error",
                }; 
            }
        }
    }
}
