using FluentValidation;

namespace XLog.Category.Infrastructure.UseCases.GetCountry
{
    public class GetCountryByIdValidator : AbstractValidator<GetCountryByIdCommand>
    {
        public GetCountryByIdValidator()
        {
           RuleFor(x => x.CountryId)
               .NotNull();
        }
    }

    public class GetCountryByCodeValidator : AbstractValidator<GetCountryByCodeCommand>
    {
        public GetCountryByCodeValidator()
        {
           RuleFor(x => x.CountryCode)
               .NotNull();
        }
    }

    public class GetAllCountryValidator : AbstractValidator<GetAllCountryCommand>
    {
        public GetAllCountryValidator()
        {
        }
    }
}
