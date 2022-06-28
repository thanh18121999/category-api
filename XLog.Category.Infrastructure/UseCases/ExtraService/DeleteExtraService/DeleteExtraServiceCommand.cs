using System;
using MediatR;
using XLog.Category.Application.UseCases.GetExtraService;

namespace XLog.Category.Infrastructure.UseCases.DeleteExtraService
{
    public class DeleteExtraServiceCommand : IRequest<DeleteExtraServiceResponse>, IDeleteExtraService
    {
        public string extraServiceID { get; set; }
    }
}
