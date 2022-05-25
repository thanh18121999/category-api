using System;

namespace XLog.Category.Infrastructure.Dto
{
    public class MerchandiseTypeDto
    {
        
        public string Id { get; set; }
        public string? Description { get; set; }
        public string? MerchandiseDescription { get; set; }
        public int IdService { get; set; }
        public int Active { get; set; }
    }
}
