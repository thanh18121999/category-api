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
//using XLog.Category.Infrastructure.UseCases.GetPartner;

namespace XLog.Category.Infrastructure.UseCases.GetDeliveryState
{
    public class GetAllDeliveryStateHandler : IRequestHandler<GetAllDeliveryStateCommand, GetAllDeliveryStateResponse>
    {
        private readonly IDeliveryStateRepository _deliveryStateRepository;
        private readonly IMapper _mapper;

        public GetAllDeliveryStateHandler(IDeliveryStateRepository deliveryStateRepository, IMapper mapper)
        {
            _deliveryStateRepository = deliveryStateRepository;
            _mapper = mapper;
        }

        public async Task<GetAllDeliveryStateResponse> Handle(GetAllDeliveryStateCommand command, CancellationToken cancellationToken)
        {
            try {
                var deliverystates = await _deliveryStateRepository.GetAll(cancellationToken);

                return new GetAllDeliveryStateResponse
                {
                    StatusCode = System.Net.HttpStatusCode.OK,
                    message = "Success",
                    responses = _mapper.Map<IEnumerable<DELIVERYSTATES>>(deliverystates)
                };
            }
            catch {
                return new GetAllDeliveryStateResponse
                {
                    StatusCode = System.Net.HttpStatusCode.InternalServerError,
                    message = "Error",
                };
            }
        }

         
    }
}
