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

namespace XLog.Category.Infrastructure.UseCases.AddTransportType
{
    public class AddTransportTypeHandler : IRequestHandler<AddTransportTypeCommand, AddTransportTypeResponse>
    {
        private readonly ITransportTypeRepository _transportTypeRepository;
        private readonly IMapper _mapper;

        public AddTransportTypeHandler(ITransportTypeRepository transportTypeRepository, IMapper mapper)
        {
            _transportTypeRepository = transportTypeRepository;
            _mapper = mapper;
        }

        public async Task<AddTransportTypeResponse> Handle(AddTransportTypeCommand command, CancellationToken cancellationToken)
        {
            try {
                List<Domain.TRANSPORTTYPES> AddedTransportTypes = new List<Domain.TRANSPORTTYPES>();
                foreach (AddTransportTypeItem transportTypeItem in command.transportTypeItems)
                {
                    Domain.TRANSPORTTYPES transportType = _mapper.Map<Domain.TRANSPORTTYPES>(transportTypeItem);
                    await _transportTypeRepository.AddAsync(transportType, cancellationToken);  
                    AddedTransportTypes.Add(transportType);               
                }
                await _transportTypeRepository.SaveChangesAsync(cancellationToken);
                return new AddTransportTypeResponse
                {
                    StatusCode = System.Net.HttpStatusCode.OK,
                    message = "Success",
                };
            }
            catch {
                return new AddTransportTypeResponse
                {
                    StatusCode = System.Net.HttpStatusCode.InternalServerError,
                    message = "Error",
                }; 
            }
        }
    }
}
