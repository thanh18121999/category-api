using System;
using MediatR;
using XLog.Category.Application.UseCases.GetExtraService;

namespace XLog.Category.Infrastructure.UseCases.GetExtraService
{
    public class GetExtraServiceCommand : IRequest<GetExtraServiceResponse>, IGetExtraService
    {
        public string ExtraServiceID { get; set; }
    }
    public class GetAllExtraServiceCommand : IRequest<GetAllExtraServiceResponse>
    {

    }
}
