using System;
using MediatR;
using XLog.Category.Application.UseCases.GetCountry;

namespace XLog.Category.Infrastructure.UseCases.GetCountry
{
    public class GetCountryByIdCommand : IRequest<GetCountryResponse>, IGetCountryById
    {
        public int CountryId { get; set; }
    }
    public class GetCountryByCodeCommand : IRequest<GetCountryResponse>, IGetCountryByCode
    {
        public string CountryCode { get; set; }
    }
    public class GetAllCountryCommand : IRequest<GetAllCountryResponse>
    {

    }
}
