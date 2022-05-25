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
using XLog.Category.Application.UseCases.GetDeliveryMethod;

namespace XLog.Category.Infrastructure.UseCases.UpdateDeliveryMethod
{
    public class UpdateDeliveryMethodHandler : IRequestHandler<UpdateDeliveryMethodCommand, UpdateDeliveryMethodResponse>
    {
        private readonly IDeliveryMethodRepository _deliveryMethodRepository;
        private readonly IMapper _mapper;

        public UpdateDeliveryMethodHandler(IDeliveryMethodRepository deliveryMethodRepository, IMapper mapper)
        {
            _deliveryMethodRepository = deliveryMethodRepository;
            _mapper = mapper;
        }

        public async Task<UpdateDeliveryMethodResponse> Handle(UpdateDeliveryMethodCommand command, CancellationToken cancellationToken)
        {
            try {
                List<Domain.DELIVERYMETHODS> UpdatedDeliveryMethods = new List<Domain.DELIVERYMETHODS>();
                foreach (UpdateDeliveryMethodItem deliveryMethodItem in command.deliveryMethods)
                {
                    Domain.DELIVERYMETHODS deliverymethod = _mapper.Map<Domain.DELIVERYMETHODS>(deliveryMethodItem);
                    _deliveryMethodRepository.Update(deliverymethod);  
                    UpdatedDeliveryMethods.Add(deliverymethod);               
                }
                await _deliveryMethodRepository.SaveChangesAsync(cancellationToken);
                return new UpdateDeliveryMethodResponse
                {
                    StatusCode = System.Net.HttpStatusCode.OK,
                    message = "Success",
                };
            }
            catch {
                return new UpdateDeliveryMethodResponse
                {
                    StatusCode = System.Net.HttpStatusCode.InternalServerError,
                    message = "Error",
                }; 
            }
        }
    }
}
