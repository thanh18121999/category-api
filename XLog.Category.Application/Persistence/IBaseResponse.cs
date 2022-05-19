using System.Net;
using System.Collections.Generic;

namespace XLog.Category.Application.Persistence
{
    public interface BaseResponse<T> where T : class
    {
        public HttpStatusCode StatusCode {get; set;}
        public string message {get; set;}
        public T responses {get; set;}
    }
    public interface BaseResponseList<T> where T : class
    {
        public HttpStatusCode StatusCode {get; set;}
        public string message {get; set;}
        public IEnumerable<T> responses {get; set;}
    }
}
