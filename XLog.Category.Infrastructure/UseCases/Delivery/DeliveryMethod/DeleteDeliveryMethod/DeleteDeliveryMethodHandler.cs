using System.Net;
using System.Threading;
using System.Threading.Tasks;
using AutoMapper;
using MediatR;
using XLog.Category.Application.Persistence;
using XLog.Category.Domain;
using XLog.Category.Infrastructure.UseCases.DeleteDeliveryMethod;

namespace XLog.Category.Infrastructure.UseCases.DeleteDeliveryMethod
{
    public class DeleteDeliveryMethodHandler : IRequestHandler<DeleteDeliveryMethodCommand, DeleteDeliveryMethodResponse>
    {
        private readonly IDeliveryMethodRepository _deliveryMethodRepository;
        private readonly IMapper _mapper;

        public DeleteDeliveryMethodHandler(IDeliveryMethodRepository deliveryMethodRepository, IMapper mapper)
        {
            _deliveryMethodRepository = deliveryMethodRepository;
            _mapper = mapper;
        }

        public async Task<DeleteDeliveryMethodResponse> Handle(DeleteDeliveryMethodCommand command, CancellationToken cancellationToken)
        {
            try {
                _deliveryMethodRepository.Remove(new DELIVERYMETHODS { ID = command.ID});
                var result = await _deliveryMethodRepository.SaveChangesAsync(cancellationToken);
                return new DeleteDeliveryMethodResponse {
                    StatusCode = System.Net.HttpStatusCode.OK,
                    message = "Success",
                };
            }
            catch {
                return new DeleteDeliveryMethodResponse {
                    StatusCode = System.Net.HttpStatusCode.InternalServerError,
                    message = "Error",
                }; 
            }
            
        }
    }
}
