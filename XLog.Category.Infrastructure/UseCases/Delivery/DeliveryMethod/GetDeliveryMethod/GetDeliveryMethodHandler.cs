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

namespace XLog.Category.Infrastructure.UseCases.GetDeliveryMethod
{
    public class GetAllDeliveryMethodHandler : IRequestHandler<GetAllDeliveryMethodCommand, GetAllDeliveryMethodResponse>
    {
        private readonly IDeliveryMethodRepository _deliveryMethodRepository;
        private readonly IMapper _mapper;

        public GetAllDeliveryMethodHandler(IDeliveryMethodRepository deliveryMethodRepository, IMapper mapper)
        {
            _deliveryMethodRepository = deliveryMethodRepository;
            _mapper = mapper;
        }

        public async Task<GetAllDeliveryMethodResponse> Handle(GetAllDeliveryMethodCommand command, CancellationToken cancellationToken)
        {
            try {
                var deliverymethods = await _deliveryMethodRepository.GetAll(cancellationToken);

                return new GetAllDeliveryMethodResponse
                {
                    StatusCode = System.Net.HttpStatusCode.OK,
                    message = "Success",
                    responses = _mapper.Map<IEnumerable<DELIVERYMETHODS>>(deliverymethods)
                };
            }
            catch {
                return new GetAllDeliveryMethodResponse
                {
                    StatusCode = System.Net.HttpStatusCode.InternalServerError,
                    message = "Error",
                };
            }
        }

         
    }
}
