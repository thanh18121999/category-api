using System;

namespace XLog.Category.Infrastructure.Dto
{
    public class UserGroupDto
    {
        public UserGroupDto(string code, string name, string name2, string note, string isactive)
        {
            Code = code;
            Name = name;
            Name2 = name2;
            Note = note;
            IsActive = isactive;
           
        }
        public string? Code { get; set; }
        public string? Name { get; set; }

        public string? Name2 { get; set; }
        public string? Note { get; set; }
        public string? IsActive { get; set; }
    }
}
