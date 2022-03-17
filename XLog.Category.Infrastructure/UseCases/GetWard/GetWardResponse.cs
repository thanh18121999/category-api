using System.Collections.Generic;
using XLog.Category.Domain;
using XLog.Category.Infrastructure.Dto;

namespace XLog.Category.Infrastructure.UseCases.GetWard
{
    public class GetWardResponse
    {
        public Ward Ward { get; set; } 
    }

    public class GetAllWardResponse
    {
        public IEnumerable<Ward> Wards { get; set; } 
    }
}
