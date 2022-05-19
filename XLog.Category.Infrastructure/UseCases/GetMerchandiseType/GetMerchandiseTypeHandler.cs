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

namespace XLog.Category.Infrastructure.UseCases.GetMerchandiseType
{
    public class GetMerchandiseTypeHandler : IRequestHandler<GetMerchandiseTypeCommand, GetMerchandiseTypeResponse>
    {
        private readonly IMerchandiseTypeRepository _merchandiseTypeRepository;
        private readonly IMapper _mapper;

        public GetMerchandiseTypeHandler(IMerchandiseTypeRepository merchandiseTypeRepository, IMapper mapper)
        {
            _merchandiseTypeRepository = merchandiseTypeRepository;
            _mapper = mapper;
        }

        public async Task<GetMerchandiseTypeResponse> Handle(GetMerchandiseTypeCommand command, CancellationToken cancellationToken)
        {
            try {
                var merchandisetype = await _merchandiseTypeRepository.GetMerchandiseType(command.MerchandiseTypeID, cancellationToken);

                return new GetMerchandiseTypeResponse
                {
                    StatusCode = System.Net.HttpStatusCode.OK,
                    message = "Success",
                    responses = _mapper.Map<MERCHANDISETYPE>(merchandisetype)
                };
            }
            catch {
                return new GetMerchandiseTypeResponse
                {
                    StatusCode = System.Net.HttpStatusCode.InternalServerError,
                    message = "Error",
                };
            }
        }
    }
    public class GetAllMerchandiseTypeHandler : IRequestHandler<GetAllMerchandiseTypeCommand, GetAllMerchandiseTypeResponse>
    {
            private readonly IMerchandiseTypeRepository _merchandiseTypeRepository;
            private readonly IMapper _mapper;

            public GetAllMerchandiseTypeHandler(IMerchandiseTypeRepository merchandiseTypeRepository, IMapper mapper)
            {
                _merchandiseTypeRepository = merchandiseTypeRepository;
                _mapper = mapper;
            }

            public async Task<GetAllMerchandiseTypeResponse> Handle(GetAllMerchandiseTypeCommand command, CancellationToken cancellationToken)
            {
                try{
                    var allmerchandisetype = await _merchandiseTypeRepository.GetAll(cancellationToken);

                    return new GetAllMerchandiseTypeResponse
                    {
                        StatusCode = System.Net.HttpStatusCode.OK,
                        message = "Success",
                        responses = _mapper.Map<IEnumerable<MerchandiseTypeDto>>(allmerchandisetype),
                    };
                }
                catch{
                    return new GetAllMerchandiseTypeResponse
                    {
                        StatusCode = System.Net.HttpStatusCode.InternalServerError,
                        message = "Error",
                    };
                }
            }
    }
}


