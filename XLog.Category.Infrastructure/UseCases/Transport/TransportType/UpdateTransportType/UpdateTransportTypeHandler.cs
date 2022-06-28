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
using XLog.Category.Application.UseCases.GetTransportType;

namespace XLog.Category.Infrastructure.UseCases.UpdateTransportType
{
    public class UpdateTransportTypeHandler : IRequestHandler<UpdateTransportTypeCommand, UpdateTransportTypeResponse>
    {
        private readonly ITransportTypeRepository _transportTypeRepository;
        private readonly IMapper _mapper;

        public UpdateTransportTypeHandler(ITransportTypeRepository transportTypeRepository, IMapper mapper)
        {
            _transportTypeRepository = transportTypeRepository;
            _mapper = mapper;
        }

        public async Task<UpdateTransportTypeResponse> Handle(UpdateTransportTypeCommand command, CancellationToken cancellationToken)
        {
            try {
                List<Domain.TRANSPORTTYPES> UpdatedTransportTypes = new List<Domain.TRANSPORTTYPES>();
                foreach (UpdateTransportTypeItem transportTypeItem in command.transportTypes)
                {
                    Domain.TRANSPORTTYPES transporttype = _mapper.Map<Domain.TRANSPORTTYPES>(transportTypeItem);
                    _transportTypeRepository.Update(transporttype);  
                    UpdatedTransportTypes.Add(transporttype);               
                }
                await _transportTypeRepository.SaveChangesAsync(cancellationToken);
                return new UpdateTransportTypeResponse
                {
                    StatusCode = System.Net.HttpStatusCode.OK,
                    message = "Success",
                };
            }
            catch {
                return new UpdateTransportTypeResponse
                {
                    StatusCode = System.Net.HttpStatusCode.InternalServerError,
                    message = "Error",
                }; 
            }
        }
    }
}
