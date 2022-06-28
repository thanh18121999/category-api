using System.Net;
using System.Threading;
using System.Threading.Tasks;
using AutoMapper;
using MediatR;
using XLog.Category.Application.Persistence;
using XLog.Category.Domain;
using XLog.Category.Infrastructure.UseCases.DeleteExtraService;

namespace XLog.Category.Infrastructure.UseCases.DeleteExtraService
{
    public class DeleteExtraServiceHandler : IRequestHandler<DeleteExtraServiceCommand, DeleteExtraServiceResponse>
    {
        private readonly IExtraServiceRepository _extraServiceRepository;
        private readonly IMapper _mapper;

        public DeleteExtraServiceHandler(IExtraServiceRepository extraServiceRepository, IMapper mapper)
        {
            _extraServiceRepository = extraServiceRepository;
            _mapper = mapper;
        }

        public async Task<DeleteExtraServiceResponse> Handle(DeleteExtraServiceCommand command, CancellationToken cancellationToken)
        {
            try {
                _extraServiceRepository.Remove(new EXTRASERVICE { ID = command.extraServiceID });
                var result = await _extraServiceRepository.SaveChangesAsync(cancellationToken);
                return new DeleteExtraServiceResponse {
                    StatusCode = System.Net.HttpStatusCode.OK,
                    message = "Success",
                };
            }
            catch {
                return new DeleteExtraServiceResponse {
                    StatusCode = System.Net.HttpStatusCode.InternalServerError,
                    message = "Error",
                }; 
            }
            
        }
    }
}
