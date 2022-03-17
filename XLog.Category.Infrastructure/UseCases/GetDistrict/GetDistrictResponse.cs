using System.Collections.Generic;
using XLog.Category.Domain;
using XLog.Category.Infrastructure.Dto;

namespace XLog.Category.Infrastructure.UseCases.GetDistrict
{
    public class GetDistrictResponse
    {
        public DISTRICT district { get; set; } 
    }

    public class GetAllDistrictResponse
    {
        public IEnumerable<DISTRICT> districts { get; set; } 
    }
}
