using System.Net;
using XLog.Category.Domain;
using XLog.Category.Application.Persistence;

namespace XLog.Category.Infrastructure.UseCases.DeleteExtraService
{
    public class DeleteExtraServiceResponse : BaseResponse<EXTRASERVICE>
    {
        public string message { get; set; } 
        public HttpStatusCode StatusCode { get; set; } 
        public EXTRASERVICE responses { get; set; } 
    }
}
