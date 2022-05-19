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

namespace XLog.Category.Infrastructure.UseCases.GetExtraService
{
    public class GetExtraServiceHandler : IRequestHandler<GetExtraServiceCommand, GetExtraServiceResponse>
    {
        private readonly IExtraServiceRepository _extraServiceRepository;
        private readonly IMapper _mapper;

        public GetExtraServiceHandler(IExtraServiceRepository extraServiceRepository, IMapper mapper)
        {
            _extraServiceRepository = extraServiceRepository;
            _mapper = mapper;
        }

        public async Task<GetExtraServiceResponse> Handle(GetExtraServiceCommand command, CancellationToken cancellationToken)
        {
            try {
                var extraService = await _extraServiceRepository.GetExtraService(command.ExtraServiceID, cancellationToken);

                return new GetExtraServiceResponse
                {
                    StatusCode = System.Net.HttpStatusCode.OK,
                    message = "Success",
                    responses = _mapper.Map<EXTRASERVICE>(extraService)
                };
            }
            catch {
                return new GetExtraServiceResponse
                {
                    StatusCode = System.Net.HttpStatusCode.InternalServerError,
                    message = "Error",
                };
            }
        }
    }
}