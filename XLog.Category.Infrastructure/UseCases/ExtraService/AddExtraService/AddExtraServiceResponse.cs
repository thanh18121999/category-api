using System.Net;
using XLog.Category.Infrastructure.Dto;
using XLog.Category.Application.Persistence;

namespace XLog.Category.Infrastructure.UseCases.AddExtraService
{
    public class AddExtraServiceResponse : BaseResponse<ExtraServiceDto>
    {
        public string message { get; set; } 
        public HttpStatusCode StatusCode { get; set; } 
        public ExtraServiceDto responses { get; set; } 
    }
}
