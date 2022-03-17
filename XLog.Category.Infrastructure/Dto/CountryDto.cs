using System;

namespace XLog.Category.Infrastructure.Dto
{
    public class CountryDto
    {
        public CountryDto(Guid countryId, string code, string name, string standard, string dataPath, int isActive)
        {
            CountryId = countryId;
            Code = code;
            Name = name;
            Standard = standard;
            DataPath = dataPath;
            IsActive = isActive;
           
        }
        public Guid CountryId { get; set; }
        public string? Code { get; set; }
        public string? Name { get; set; }
        public string? Standard { get; set; }
        public string? DataPath { get; set; }
        public int IsActive { get; set; }
    }
}
