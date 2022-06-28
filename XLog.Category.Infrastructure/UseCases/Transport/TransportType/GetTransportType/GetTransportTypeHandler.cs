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

namespace XLog.Category.Infrastructure.UseCases.GetTransportType
{
    public class GetAllTransportTypeHandler : IRequestHandler<GetAllTransportTypeCommand, GetAllTransportTypeResponse>
    {
        private readonly ITransportTypeRepository _transportTypeRepository;
        private readonly IMapper _mapper;

        public GetAllTransportTypeHandler(ITransportTypeRepository transportTypeRepository, IMapper mapper)
        {
            _transportTypeRepository = transportTypeRepository;
            _mapper = mapper;
        }

        public async Task<GetAllTransportTypeResponse> Handle(GetAllTransportTypeCommand command, CancellationToken cancellationToken)
        {
            try {
                var transporttypes = await _transportTypeRepository.GetAll(cancellationToken);

                return new GetAllTransportTypeResponse
                {
                    StatusCode = System.Net.HttpStatusCode.OK,
                    message = "Success",
                    responses = _mapper.Map<IEnumerable<TRANSPORTTYPES>>(transporttypes)
                };
            }
            catch {
                return new GetAllTransportTypeResponse
                {
                    StatusCode = System.Net.HttpStatusCode.InternalServerError,
                    message = "Error",
                };
            }
        }

         
    }
}
