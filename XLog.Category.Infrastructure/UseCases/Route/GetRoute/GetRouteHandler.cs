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

namespace XLog.Category.Infrastructure.UseCases.GetRoute
{
    public class GetAllRouteHandler : IRequestHandler<GetAllRouteCommand, GetAllRouteResponse>
    {
        private readonly IRouteRepository _routeRepository;
        private readonly IMapper _mapper;

        public GetAllRouteHandler(IRouteRepository routeRepository, IMapper mapper)
        {
            _routeRepository = routeRepository;
            _mapper = mapper;
        }

        public async Task<GetAllRouteResponse> Handle(GetAllRouteCommand command, CancellationToken cancellationToken)
        {
            try {
                var Routes = await _routeRepository.GetAll(cancellationToken);

                return new GetAllRouteResponse
                {
                    StatusCode = System.Net.HttpStatusCode.OK,
                    message = "Success",
                    responses = _mapper.Map<IEnumerable<ROUTES>>(Routes)
                };
            }
            catch {
                return new GetAllRouteResponse
                {
                    StatusCode = System.Net.HttpStatusCode.InternalServerError,
                    message = "Error",
                };
            }
        }

         
    }
}
