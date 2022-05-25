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

namespace XLog.Category.Infrastructure.UseCases.AddDeliveryMethod
{
    public class AddDeliveryMethodHandler : IRequestHandler<AddDeliveryMethodCommand, AddDeliveryMethodResponse>
    {
        private readonly IDeliveryMethodRepository _deliveryMethodRepository;
        private readonly IMapper _mapper;

        public AddDeliveryMethodHandler(IDeliveryMethodRepository deliveryMethodRepository, IMapper mapper)
        {
            _deliveryMethodRepository = deliveryMethodRepository;
            _mapper = mapper;
        }

        public async Task<AddDeliveryMethodResponse> Handle(AddDeliveryMethodCommand command, CancellationToken cancellationToken)
        {
            try {
                List<Domain.DELIVERYMETHODS> AddedDeliveryMethods = new List<Domain.DELIVERYMETHODS>();
                foreach (AddDeliveryMethodItem delilveryMethodItem in command.deliveryMethodItems)
                {
                    Domain.DELIVERYMETHODS deliveryMethod = _mapper.Map<Domain.DELIVERYMETHODS>(delilveryMethodItem);
                    await _deliveryMethodRepository.AddAsync(deliveryMethod, cancellationToken);  
                    AddedDeliveryMethods.Add(deliveryMethod);               
                }
                await _deliveryMethodRepository.SaveChangesAsync(cancellationToken);
                return new AddDeliveryMethodResponse
                {
                    StatusCode = System.Net.HttpStatusCode.OK,
                    message = "Success",
                };
            }
            catch {
                return new AddDeliveryMethodResponse
                {
                    StatusCode = System.Net.HttpStatusCode.InternalServerError,
                    message = "Error",
                }; 
            }
        }
    }
}
