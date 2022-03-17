using System;

namespace XLog.Category.Application.UseCases.CreatePostalCode
{
    public interface ICreatePostalCode
    {
        public Guid PostalCodeId { get; }
        public string Code { get; }
        public string Name { get; }
        public Guid CountryId { get; set; }

    }
}
